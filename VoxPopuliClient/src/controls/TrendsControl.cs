using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using VoxPopuliClient.comms;
using VoxPopuliClient.models;
using System.IO;
using Newtonsoft.Json;
using VoxPopuliClient.events;
using VoxPopuliClient.src.forms;

namespace VoxPopuliClient.src.controls
{
  public partial class TrendsControl : UserControl
  {
    Dictionary<string, TrendItem> TrendCache;
    string TrendFile = ".\\data\\trends.json";

    public TrendsControl()
    {
      InitializeComponent();

      backgroundWorker1.WorkerSupportsCancellation = true;
      backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
      backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
      TrendCache = new Dictionary<string, TrendItem>();
      EventBus.TrendRequest += EventBus_TrendRequest;
    }

    private void EventBus_TrendRequest(object sender, TrendRequestEvent e)
    {
      GetTrends();
    }

    public void Setup()
    {
      GetTrends();
    }

    public void OnClose()
    {
      if (backgroundWorker1.IsBusy)
      {
        backgroundWorker1.CancelAsync();
      }
      EventBus.TrendRequest -= EventBus_TrendRequest;
    }

    void LoadTrendCache()
    {
      if (File.Exists(TrendFile))
      {
        string sData = File.ReadAllText(TrendFile);
        TrendCache = JsonConvert.DeserializeObject<Dictionary<string, TrendItem>>(sData);
        if (TrendCache == null)
        {
          TrendCache = new Dictionary<string, TrendItem>();
        }
      }
      else
      {
        TrendCache = new Dictionary<string, TrendItem>();
      }

      //if the trend db is too large, trim it down
      while (TrendCache.Count > 100)
      {
        string sKey = TrendCache.First().Key;
        if (!string.IsNullOrEmpty(sKey))
        {
          TrendCache.Remove(sKey);
        }
      }
    }

    void SaveTrendCache()
    {
      string sData = JsonConvert.SerializeObject(TrendCache);
      File.WriteAllText(TrendFile, sData);
    }

    private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      for (int i = 0; i < TrendsView.Items.Count; i++)
      {
        if (backgroundWorker1.CancellationPending) break;
        string sURL = "";

        Invoke((MethodInvoker)delegate
        {
          ListViewItem lvi = TrendsView.Items[i];
          sURL = lvi.SubItems[1].Text;
        });

        string sData = GetData(sURL);
        if (string.IsNullOrEmpty(sData))
        {
          sData = sURL;
        }
        
        if (backgroundWorker1.CancellationPending) break;
        Invoke((MethodInvoker)delegate
        {
          ListViewItem lvi = TrendsView.Items[i];
          lvi.SubItems[2].Text = sData;
        });

        SaveTrendCache();
      }
    }

    private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      SaveTrendCache();
    }

    string GetData(string sURL)
    {
      if (TrendCache.ContainsKey(sURL))
      {
        return TrendCache[sURL].Description;
      }
      if (sURL.Contains("youtube"))
      {
        string Results = Server.Request(sURL);
        string sFilter = @"<meta name=""description"" content=""[^>]*"">";
        Regex reg = new Regex(sFilter);
        string Desc = reg.Match(Results).Value;
        Desc = Desc.Replace(@"<meta name=""description"" content=""", "");
        Desc = Desc.Replace(@">""", "");
        TrendCache.Add(sURL, new TrendItem() { URL = sURL, Description = Desc });
        return Desc;
      }
      else if (sURL.Contains("imdb"))
      {
        string Results = Server.Request(sURL);
        string sFilter = @"<meta name=""title"" content=""[^\/>]*""?\/>";
        Regex reg = new Regex(sFilter);
        string Desc = reg.Match(Results).Value;
        Desc = Desc.Replace(@"<meta name=""title"" content=""", "");
        Desc = Desc.Replace(@""" />", "");
        Desc = Desc.Replace(@"""/>", "");
        TrendCache.Add(sURL, new TrendItem() { URL = sURL, Description = Desc });
        return Desc;
      }
      else if (sURL.Contains("rottentomatoes"))
      {
        string Results = Server.Request(sURL);
        string sFilter = @"(<title>)(.+?)(<\/title>)";
        Regex reg = new Regex(sFilter);
        string Desc = reg.Match(Results).Value;
        Desc = Desc.Replace(@"<title>", "");
        Desc = Desc.Replace(@"</title>", "");
        Desc = Desc.Replace(@""" />", "");
        Desc = Desc.Replace(@"""/>", "");
        TrendCache.Add(sURL, new TrendItem() { URL = sURL, Description = Desc });
        return Desc;
      }
      else
      {
        string Results = Server.Request(sURL);
        string sFilter = @"(<title>)(.+?)(<\/title>)";
        Regex reg = new Regex(sFilter);
        if (Results == null) return "";
        string Desc = reg.Match(Results).Value;
        Desc = Desc.Replace(@"<title>", "");
        Desc = Desc.Replace(@"</title>", "");
        Desc = Desc.Replace(@""" />", "");
        Desc = Desc.Replace(@"""/>", "");
        if (string.IsNullOrEmpty(Desc))
        {
          return sURL;
        }
        else
        {
          TrendCache.Add(sURL, new TrendItem() { URL = sURL, Description = Desc });
          return Desc;
        }
      }
    }

    private void RefreshButton_Click(object sender, EventArgs e)
    {
      GetTrends();
    }

    void ParseResults(string s)
    {
      if (string.IsNullOrEmpty(s)) return;

      TrendsView.Items.Clear();
      string[] Items = s.Split('\n');
      foreach (string Item in Items)
      {
        string[] entry = Item.Split('|');
        if (entry.Length < 2) continue;
        string sDate = entry[0];
        string sURL = entry[1];
        ListViewItem lvi = new ListViewItem(sDate);
        lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, sURL));
        lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, sURL));
        lvi.Tag = sURL;
        TrendsView.Items.Add(lvi);
      }
    }

    void GetTrends()
    {
      if (string.IsNullOrEmpty(Globals.CurrentURL)) return;

      string sURL = Globals.settings.ServerURL
        + "?f=gt&uid=" + Globals.settings.GUID
        + "&last=" + "123"; //last time
      string Results = Server.Request(sURL);
      ParseResults(Results);
      LoadTrendCache();
      if (backgroundWorker1.IsBusy)
      {
        backgroundWorker1.CancelAsync();
      }
      else
      {
        backgroundWorker1.RunWorkerAsync();
      }
    }

    private void TrendsForm_Shown(object sender, EventArgs e)
    {

    }

    private void TrendsView_DoubleClick(object sender, EventArgs e)
    {
      if (TrendsView.SelectedItems.Count == 0) return;
      ListViewItem lvi = TrendsView.SelectedItems[0];
      if (lvi == null) return;
      string sURL = (string)lvi.Tag;
      EventBus.BrowseTo(sURL);
    }

    private void TrendsForm_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void PopOutButton_Click(object sender, EventArgs e)
    {
      TrendsForm f = new TrendsForm();
      f.Show();
    }

    private void RefreshButton_Click_1(object sender, EventArgs e)
    {
      GetTrends();
    }
  }
}
