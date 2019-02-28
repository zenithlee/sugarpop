using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.events;
using VoxPopuliClient.models;
using Newtonsoft.Json;
using System.IO;

namespace VoxPopuliClient.src.controls
{
  public partial class URLBar : UserControl
  {
    string FavoritesFile = "favorites.json";
    List<Favorite> Favorites = new List<Favorite>();
    public URLBar()
    {
      InitializeComponent();
      EventBus.URLChangedHandler += EventBus_URLChangedHandler;
      
    }

    public void Setup()
    {
      LoadFavorites();
      URLBox.Text = Globals.CurrentURL;
    }

    void SaveFavorites()
    {
      string sData = JsonConvert.SerializeObject(Favorites);
      File.WriteAllText(Path.Combine("data", FavoritesFile), sData);
    }

    void LoadFavorites()
    {
      if (!File.Exists(Path.Combine("data", FavoritesFile)))
      {
        Favorites = new List<Favorite>();
      }
      else
      {
        string sData = File.ReadAllText(Path.Combine("data", FavoritesFile));
        try
        {
          Favorites = JsonConvert.DeserializeObject<List<Favorite>>(sData);
        }
        catch (Exception e)
        {
          EventBus.Stats("Error loading favorites");
        }
      }
      PopulateFavorites();
    }

    void PopulateFavorites()
    {
      flowLayoutPanel1.Controls.Clear();
      foreach (Favorite f in Favorites)
      {
        Button b = new Button();
        b.Text = "";
        b.ImageList = imageList1;
        b.ImageIndex = 0;
        b.AutoSize = true;
        b.FlatStyle = FlatStyle.Flat;
        b.ImageAlign = ContentAlignment.MiddleLeft;
        b.TextImageRelation = TextImageRelation.ImageBeforeText;
        b.FlatAppearance.BorderSize = 0;
        b.Margin = new Padding(0);
        b.Height = flowLayoutPanel1.Height;
        b.Text = f.Title;
        b.Tag = f;
        b.Click += B_Click;
        b.ContextMenuStrip = contextMenuStrip1;
        flowLayoutPanel1.Controls.Add(b);
      }
    }

    private void B_Click(object sender, EventArgs e)
    {
      Button b = (Button)sender;
      if (b == null) return;
      Favorite f = (Favorite)b.Tag;
      EventBus.BrowseTo(f.URL);
    }

    private void EventBus_URLChangedHandler(object sender, TextEvent e)
    {
      URLBox.Text = e.Text;
    }

    private void GoButton_Click(object sender, EventArgs e)
    {
      Globals.CurrentURL = URLBox.Text.Trim();
      EventBus.BrowseTo(URLBox.Text);
    }

    string SanitizeURL(string s)
    {
      string Result = s.Trim();
      if (!Result.StartsWith("http"))
      {
        Result = "http://" + Result;
      }
      return Result;
    }

    private void URLBox_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return)
      {
        string sURL = SanitizeURL(URLBox.Text);
        Globals.CurrentURL = sURL;
        EventBus.BrowseTo(sURL);
      }
    }

    private void FavoriteButton_Click(object sender, EventArgs e)
    {
      Favorite f = new Favorite();
      f.URL = Globals.CurrentURL;
      f.Title = Globals.CurrentTitle;
      Favorites.Add(f);
      SaveFavorites();
      PopulateFavorites();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Button b = (Button)contextMenuStrip1.SourceControl;
      if (b == null) return;
      Favorite f = (Favorite)b.Tag;
      Favorites.Remove(f);
      SaveFavorites();
      PopulateFavorites();

    }

    private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return)
      {
        Button b = (Button)contextMenuStrip1.SourceControl;
        if (b == null) return;
        Favorite f = (Favorite)b.Tag;
        f.Title = toolStripTextBox1.Text;
        SaveFavorites();
        PopulateFavorites();
        contextMenuStrip1.Close();
      }
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
      Button b = (Button)contextMenuStrip1.SourceControl;
      if (b == null) return;
      Favorite f = (Favorite)b.Tag;
      toolStripTextBox1.Text = f.Title;
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
      EventBus.NavigateBack("Back");
    }

    private void FwdButton_Click(object sender, EventArgs e)
    {
      EventBus.NavigateForward("Forward");
    }
  }
}
