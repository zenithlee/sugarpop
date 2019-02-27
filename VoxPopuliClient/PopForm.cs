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
using VoxPopuliClient.src;
using VoxPopuliClient.src.controls;

namespace VoxPopuliClient
{
  public partial class PopForm : Form
  {
    bool CompactMode = false;
    int CompactWidth = 400;
    int FullWidth = 800;
    int FullSplit = 600;

    public PopForm()
    {
      InitializeComponent();

      EventBus.StatusHandler += EventBus_StatusHandler;
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
        urlBar1.Setup();
        BrowserOptions bo = new BrowserOptions();
        EventBus.BrowseTo(Globals.CurrentURL);
        chatList1.Setup();        
      }
    }

    private void PopForm_Load(object sender, EventArgs e)
    {      
      
    }

    private void PopForm_Shown(object sender, EventArgs e)
    {
      Setup();
    }

    private void CompactModeButton_Click(object sender, EventArgs e)
    {
      CompactMode = !CompactMode;
      if ( CompactMode == true)
      {
        splitContainer1.Panel1Collapsed = true;
        FullWidth = Width;
        Width = CompactWidth;
        FullSplit = splitContainer1.SplitterDistance;
        splitContainer1.SplitterDistance = 1;

      }
      else
      {
        splitContainer1.Panel1Collapsed = false;
        Width = FullWidth;
        splitContainer1.SplitterDistance = FullSplit;
      }

      PerformLayout();
      
    }
  }
}
