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
    }

    public void Insert(string s)
    {
      CommentBox.Text = s + CommentBox.Text;
    }

    void SendComment()
    {
      if (string.IsNullOrEmpty(UserNameBox.Text))
      {
        UserNameBox.Text = "Anon";
      }

      ChatItem chat = new ChatItem()
      {
        Text = CommentBox.Text,
        UserID = UserNameBox.Text,
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

      if (Result.Contains("ERROR"))
      {
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
      if ( e.KeyCode == Keys.Return)
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
      TrendsForm tf = new TrendsForm();
      tf.Show(this);
    }
  }
}
