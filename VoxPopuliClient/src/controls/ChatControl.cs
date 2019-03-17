using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using VoxPopuliClient.events;
using VoxPopuliClient.comms;
using VoxPopuliClient.models;
using Newtonsoft.Json;
using System.Threading;
using VoxPopuliClient.src.forms;

namespace VoxPopuliClient.src.controls
{
  public partial class ChatControl : UserControl
  {
    public ChatControl()
    {
      InitializeComponent();

      EventBus.ChannelChangedHandler += EventBus_ChannelChangedHandler;
      UpdateDescription();
      ChannelCombo.Items.Clear();
      ChannelCombo.Items.AddRange(Channels.GetInstance().GetList());
    }

    private void EventBus_ChannelChangedHandler(object sender, TextEvent e)
    {
      UpdateDescription();      
    }

    public void Insert(string s)
    {
      CommentBox.Text = s + CommentBox.Text;
    }

    void UpdateDescription()
    {
      ChatDescr.Text = "Commenting as " + Globals.UserName + " in " + Channels.ChannelCurrent;
      string desc = Channels.GetInstance().GetDescription(Channels.ChannelCurrent);
      EventBus.Stats("Channel changed to :" + Channels.ChannelCurrent + " -> " + desc);
    }

    void SendComment()
    {
      if (string.IsNullOrEmpty(Globals.settings.ScreenName))
      {
        Globals.settings.ScreenName = "Anon";
      }

      ChatItem chat = new ChatItem()
      {
        Text = CommentBox.Text,
        Channel = ChannelCombo.Text,
        UserID = Globals.settings.ScreenName,
        UserGUID = Globals.settings.GUID,
        time = DateTime.Now.ToUniversalTime(),
        Attachments = ""
      };
      EventBus.ChatResponse(chat);
      Thread.Sleep(100);

      string sChatData = JsonConvert.SerializeObject(chat);

      string sURL = Globals.settings.ServerURL
        + "?f=mc&uid=" + Globals.UserName
        + "&co=" + sChatData
        + "&url=" + Globals.CurrentURL;
      string Result = Server.Request(sURL);

      if( string.IsNullOrEmpty(Result) || Result.Contains("ERROR"))
      {
        EventBus.Stats("Error sending message. Try again...");
      }
      else
      {
        CommentBox.Text = "";
      }     
    }

    private void CommentButton_Click(object sender, EventArgs e)
    {
      SendComment();
    }

    private void CommentBox_TextChanged(object sender, EventArgs e)
    {
      TextCounter.Text = (CommentBox.MaxLength - CommentBox.Text.Length).ToString();
    }

    private void CommentBox_KeyUp(object sender, KeyEventArgs e)
    {
      if (( e.KeyCode == Keys.Return) && (e.Shift == false))
      {
        SendComment();
      }
    }

    private void SmileButton_Click(object sender, EventArgs e)
    {
      CommentBox.Text += ":)p";
    }

    private void GetTrendsButton_Click(object sender, EventArgs e)
    {
      //TrendsForm tf = new TrendsForm();
      //tf.Show(this);
      EventBus.RequestTrends(true);
    }

    private void ChannelCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      EventBus.ChangeChannelRequest(ChannelCombo.Text);      
    }
  }
}
