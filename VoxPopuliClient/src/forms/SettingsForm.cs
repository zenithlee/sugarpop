using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoxPopuliClient.src.controls
{
  public partial class SettingsForm : Form
  {
    public SettingsForm()
    {
      InitializeComponent();

      if (Globals.settings != null)
      {
        ServerText.Text = Globals.settings.ServerURL;
        StartCompactCheck.Checked = Globals.settings.StartInCompactMode;
      }
    }

    private void OKButton_Click(object sender, EventArgs e)
    {
      Globals.settings.ServerURL = ServerText.Text;
      Globals.settings.StartInCompactMode = StartCompactCheck.Checked;
      Globals.settings.Save();
      Close();
    }
  }
}
