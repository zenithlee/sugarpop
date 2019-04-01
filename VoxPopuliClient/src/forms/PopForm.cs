using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.events;
using VoxPopuliClient.models;
using VoxPopuliClient.services;
using VoxPopuliClient.src;
using VoxPopuliClient.src.controls;

namespace VoxPopuliClient
{
  public partial class PopForm : Form
  {
    int CompactWidth = 400;
    int FullWidth = 800;
    int FullSplit = 600;

    public PopForm()
    {
      InitializeComponent();
      FullWidth = Width;
      FullSplit = splitContainer1.SplitterDistance;
      EventBus.StatusHandler += EventBus_StatusHandler;
      EventBus.TrendRequest += EventBus_TrendRequest;
      EventBus.ChannelChangeRequestHandler += EventBus_ChannelChangeRequestHandler;
      EventBus.BrowseToHandler += EventBus_BrowseToHandler;
      EventBus.TopMostChangedHandler += EventBus_TopMostChangedHandler;
    }

    private void EventBus_TopMostChangedHandler(object sender, BooleanEvent e)
    {
      this.TopMost = e.value;
    }

    private void EventBus_BrowseToHandler(object sender, TextEvent e)
    {
      BrowserSync.BrowseTo(e.Text);
    }

    private void EventBus_ChannelChangeRequestHandler(object sender, TextEvent e)
    {
      Channels.ChannelCurrent = e.Text;
      EventBus.ChangedChannel(Channels.ChannelCurrent);
    }

    private void EventBus_TrendRequest(object sender, TrendRequestEvent e)
    {
      splitContainer2.Panel1Collapsed = !splitContainer2.Panel1Collapsed;
      if (splitContainer2.Panel1Collapsed == true)
      {
        try
        {
          splitContainer1.SplitterDistance = Width - (400);
          splitContainer2.SplitterDistance = 0;
        }
        catch (Exception ex)
        {
          EventBus.Stats("Could not find enough space");
        }
      }
      else
      {
        try
        {
          splitContainer1.SplitterDistance = Width - (730);
          splitContainer2.SplitterDistance = splitContainer2.Width / 2;
        }
        catch (Exception ex)
        {
          EventBus.Stats("Could not find enough space");
        }
      }
    }

    private void EventBus_StatusHandler(object sender, TextEvent e)
    {
      StatusLabel.Text = e.Text;
    }

    private void SettingsButton_Click(object sender, EventArgs e)
    {
      SettingsForm sf = new SettingsForm();
      sf.ShowDialog(this);
    }

    void Setup()
    {
      if (!Globals.IsInDesignMode())
      {
        Globals.settings = Settings.Load();
        Channels.GetInstance(); //populate channels
        Globals.InCompactMode = Globals.settings.StartInCompactMode;
        urlBar1.Setup();
        BrowserOptions bo = new BrowserOptions();
        EventBus.BrowseTo(Globals.CurrentURL);
        chatList1.Setup();
        SwitchCompactMode();
        EventBus.Stats("Welcome to SugarPop. Commenting as: " + Globals.settings.ScreenName);
        if (Globals.settings.StayOnTop == true)
        {
          this.TopMost = true;
        }
      }
    }

    private void PopForm_Load(object sender, EventArgs e)
    {

    }

    private void PopForm_Shown(object sender, EventArgs e)
    {
      Setup();
    }

    void SwitchCompactMode()
    {
      if (Globals.InCompactMode == true)
      {
        try
        {
          splitContainer1.Panel1Collapsed = true;
          FullWidth = Width;
          Width = CompactWidth;
          FullSplit = splitContainer1.SplitterDistance;
          splitContainer1.SplitterDistance = 1;
        }
        catch (Exception e)
        {
          EventBus.Stats("Close Trends first");
        }


      }
      else
      {
        try
        {
          splitContainer1.Panel1Collapsed = false;
          Width = FullWidth;
          splitContainer1.SplitterDistance = FullSplit;
        }
        catch (Exception e)
        {
          EventBus.Stats("Close Trends First");
        }
      }

      PerformLayout();
    }

    private void CompactModeButton_Click(object sender, EventArgs e)
    {
      Globals.InCompactMode = !Globals.InCompactMode;
      SwitchCompactMode();
    }
  }
}
