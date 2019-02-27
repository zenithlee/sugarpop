using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.comms;
using VoxPopuliClient.events;

namespace VoxPopuliClient.src.forms
{
  public partial class TrendsForm : Form
  {
    public TrendsForm()
    {
      InitializeComponent();
    }

    private void RefreshButton_Click(object sender, EventArgs e)
    {
      GetTrends();
    }

    void ParseResults(string s)
    {
      TrendsView.Items.Clear();
      string[] Items = s.Split('\n');
      foreach( string Item in Items)
      {
        string[] entry = Item.Split('|');
        if (entry.Length < 2) continue;
        string sDate = entry[0];
        string sURL = entry[1];
        ListViewItem lvi = new ListViewItem(sDate+":"+sURL);
        lvi.Tag = sURL;
        TrendsView.Items.Add(lvi);
      }
    }

    void GetTrends()
    {
      if (string.IsNullOrEmpty(Globals.CurrentURL)) return;

      string sURL = Globals.settings.ServerURL
        + "?f=gt&uid=" + Globals.UserName
        + "&last=" + "123"; //last time
      string Results = Server.Request(sURL);
      ParseResults(Results);
    }

    private void TrendsForm_Shown(object sender, EventArgs e)
    {
      GetTrends();
    }

    private void TrendsView_DoubleClick(object sender, EventArgs e)
    {
      if ( TrendsView.SelectedItems.Count==0) return;
      ListViewItem lvi = TrendsView.SelectedItems[0];
      if (lvi == null) return;
      string sURL = (string)lvi.Tag;
      EventBus.BrowseTo(sURL);
    }
  }
}
