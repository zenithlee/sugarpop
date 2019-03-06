using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.comms;
using VoxPopuliClient.events;
using VoxPopuliClient.models;

namespace VoxPopuliClient.src.forms
{
  public partial class TrendsForm : Form
  {
    public TrendsForm()
    {
      InitializeComponent();
    }

    private void TrendsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      trendsControl1.OnClose();
    }

    private void TrendsForm_Shown(object sender, EventArgs e)
    {
      trendsControl1.Setup();
    }
  }
}
