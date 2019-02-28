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
using VoxPopuliClient.src.controls;

namespace VoxPopuliClient.src.forms
{
  public partial class MacMain : Form
  {
    bool CompactMode = false;
    int CompactWidth = 400;
    int FullWidth = 800;
    int FullSplit = 600;

    public MacMain()
    {
      InitializeComponent();
      EventBus.StatusHandler += EventBus_StatusHandler;
    }
    void Setup()
    {
      if (!Globals.IsInDesignMode())
      {
        Globals.settings = Settings.Load();
        CompactMode = Globals.settings.StartInCompactMode;
        urlBar1.Setup();
        BrowserOptions bo = new BrowserOptions();
        EventBus.BrowseTo(Globals.CurrentURL);
        chatList1.Setup();
        SwitchCompactMode();
      }
    }

    void SwitchCompactMode()
    {
      if (CompactMode == true)
      {        
        FullWidth = Width;
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
      CompactMode = !CompactMode;
      SwitchCompactMode();
    }

    private void MacMain_Shown(object sender, EventArgs e)
    {
      Setup();
    }
  }
}
