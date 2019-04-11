using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VoxPopuliClient.events;
using VoxPopuliClient.services;

namespace VoxPopuliClient.src.controls
{
  public partial class SettingsForm : Form
  {
    public List<string> Browsers = new List<string>();

    public SettingsForm()
    {
      InitializeComponent();

      if (Globals.settings != null)
      {
        ServerText.Text = Globals.settings.ServerURL;
        StartCompactCheck.Checked = Globals.settings.StartInCompactMode;
        ScreenNameBox.Text = Globals.settings.ScreenName;
        StayOnTopCheck.Checked = Globals.settings.StayOnTop;
        SetupBrowsers();
        BrowserCombo.Text = Globals.settings.Browser;
      }
    }

    void SetupBrowsers()
    {
      Browsers.Add(BrowserSync.INTEGRATED);
      Browsers.Add(BrowserSync.FIREFOX);
      Browsers.Add(BrowserSync.CHROME);
      Browsers.Add(BrowserSync.CHROMIUM);      
      Browsers.Add(BrowserSync.EDGE);
      Browsers.Add(BrowserSync.INTERNETEXPLORER);
      Browsers.Add(BrowserSync.SAFARI);

      BrowserCombo.Items.Clear();
      BrowserCombo.Items.AddRange(Browsers.ToArray());
    }

    private void OKButton_Click(object sender, EventArgs e)
    {
      Globals.settings.ServerURL = ServerText.Text;
      Globals.settings.StartInCompactMode = StartCompactCheck.Checked;
      Globals.settings.ScreenName = ScreenNameBox.Text;
      Globals.settings.StayOnTop = StayOnTopCheck.Checked;
      Globals.settings.Browser = BrowserCombo.Text;
      Globals.settings.EncryptionKey = EncryptionKeyBox.Text;
      Globals.settings.Save();
      Close();
    }

    private void StayOnTopCheck_CheckedChanged(object sender, EventArgs e)
    {
      EventBus.ChangeTopMost(StayOnTopCheck.Checked);
    }

    private void CheckUpdatesButton_Click(object sender, EventArgs e)
    {
      EventBus.BrowseTo(Globals.CreatorURL + "?version=" + Globals.Version);
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
      EncryptionKeyBox.Text = Globals.settings.EncryptionKey;
    }
  }
}
