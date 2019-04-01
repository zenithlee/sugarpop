using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.events;
using VoxPopuliClient.models;
using VoxPopuliClient.services;
using VoxPopuliClient.src.controls;

namespace VoxPopuliClient.forms
{
  public partial class MacMain : Form
  {
    //bool CompactMode = false;
    int CompactWidth = 420;
    int FullWidth = 800;
    int FullSplit = 600;

    public MacMain()
    {
      InitializeComponent();
      EventBus.StatusHandler += EventBus_StatusHandler;
      EventBus.BrowseToHandler += EventBus_BrowseToHandler;
     
    }

    private void EventBus_BrowseToHandler(object sender, TextEvent e)
    {
      //just pass through browsing as we don't have an integrated browser
      Globals.CurrentURL = e.Text;
      EventBus.BrowseComplete(e.Text);
      EventBus.URLChanged(e.Text);
      BrowserSync.BrowseTo(e.Text);
    }

    void Setup()
    {
      if (!Globals.IsInDesignMode())
      {       
        Globals.settings = Settings.Load();
        Channels.GetInstance(); //populate channels
        Globals.settings.StartInCompactMode = true;
        Globals.InCompactMode = Globals.settings.StartInCompactMode;
        urlBar1.Setup();
        BrowserOptions bo = new BrowserOptions();
        EventBus.BrowseTo(Globals.CurrentURL);
        chatList1.Setup();
        SwitchCompactMode();
        EventBus.RequestTrends(true);
        EventBus.Stats("Welcome to SugarPop. Commenting as: " + Globals.settings.ScreenName);
        if (Globals.settings.StayOnTop == true)
        {
          this.TopMost = true;
        }
      }
    }

    void SwitchCompactMode()
    {
      if (Globals.InCompactMode == true)
      {                
        Width = CompactWidth;       
      }
      else
      {        
        Width = FullWidth;        
      }

      PerformLayout();
    }

    private void EventBus_StatusHandler(object sender, TextEvent e)
    {
      //StatusLabel.Text = e.Text;
    }

    private void SettingsButton_Click(object sender, EventArgs e)
    {
      SettingsForm sf = new SettingsForm();
      sf.ShowDialog(this);
    }

    private void CompactButton_Click(object sender, EventArgs e)
    {
      Globals.InCompactMode = !Globals.InCompactMode;
      SwitchCompactMode();
    }

    private void MacMain_Shown(object sender, EventArgs e)
    {
      Setup();
    }
  }
}
