using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.comms;
using VoxPopuliClient.events;

namespace VoxPopuliClient.src.controls
{
  //down
  //  gray
  // up
  // gray
  public partial class VoteControl : UserControl
  {
    string Up;
    string Down;
    public VoteControl()
    {
      InitializeComponent();
      EventBus.BrowseCompleteHandler += EventBus_BrowseCompleteHandler;
      Up = "0";
      Down = "0";
    }

    private void EventBus_BrowseCompleteHandler(object sender, TextEvent e)
    {
      GetVote();
    }

    private void UpVote_MouseEnter(object sender, EventArgs e)
    {
      //UpVote.ImageIndex = 2;
    }

    private void UpVote_MouseLeave(object sender, EventArgs e)
    {
      //UpVote.ImageIndex = 3;
    }

    private void DownVote_MouseEnter(object sender, EventArgs e)
    {
      //DownVote.ImageIndex = 0;
    }

    private void DownVote_MouseLeave(object sender, EventArgs e)
    {
      //DownVote.ImageIndex = 1;
    }

    void ProcessVote(string s)
    {
      if (string.IsNullOrEmpty(s)) return;
      string[] parts = s.Split('|');
      if (parts.Length < 2)
      {
        return;
      }

      Up = parts[0];
      UpVote.Text = Up;
      Down = parts[1];
      DownVote.Text = Down;

      if ( Up == "0")
      {
        UpVote.ImageIndex = 3;
      }
      else
      {
        UpVote.ImageIndex = 2;
      }

      if (Down == "0")
      {
        DownVote.ImageIndex = 1;
      }
      else
      {
        DownVote.ImageIndex = 0;
      }

    }

    void GetVote()
    {
      string serl = Globals.settings.ServerURL;

      string sURL = serl
        + "?f=gvt"
        + "&uid=" + Globals.settings.GUID
        + "&url=" + Globals.CurrentURL; //last time
      string Results = Server.Request(sURL);
      //EventBus.Stats(Results);
      ProcessVote(Results);
    }

    private void UpVote_Click(object sender, EventArgs e)
    {
      string serl = Globals.settings.ServerURL;
#if DEBUG
      //serl = "http://localhost:7057/";
#endif

      string sURL = serl
        + "?f=uvt"
        + "&uid=" + Globals.settings.GUID
        + "&url=" + Globals.CurrentURL; //last time
      string Results = Server.Request(sURL);
      EventBus.Stats(Results);
      GetVote();
    }

    private void DownVote_Click(object sender, EventArgs e)
    {
      string serl = Globals.settings.ServerURL;
#if DEBUG
      serl = "http://localhost:7057/";
#endif
      string sURL = serl
        + "?f=dvt"
        + "&uid=" + Globals.settings.GUID
        + "&url=" + Globals.CurrentURL; //last time
      string Results = Server.Request(sURL);
      EventBus.Stats(Results);
      GetVote();
    }
  }
}
