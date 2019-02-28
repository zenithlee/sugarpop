using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.src.services;

namespace VoxPopuliClient.src.controls
{
  public partial class BrowserSyncControl : UserControl
  {
    BrowserSync _sync;
    public BrowserSyncControl()
    {
      InitializeComponent();
      _sync = new BrowserSync();
    }

    private void SyncButton_Click(object sender, EventArgs e)
    {
      _sync.GetURL();
    }
  }
}
