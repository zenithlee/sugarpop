using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.events;
using VoxPopuliClient.comms;
using Newtonsoft.Json;
using VoxPopuliClient.models;

namespace VoxPopuliClient.src.controls
{
  public partial class ChatList : UserControl
  {
    bool Scrolling = false;
    Font font = new Font("Arial", 11);
    Font boldfont = new Font("Arial", 11, FontStyle.Bold);
    Brush textbrush = new SolidBrush(Color.Black);
    Brush panelbrush = new SolidBrush(Color.FromArgb(222, 180, 180));
    bool AutoScroll = true;
    public ChatList()
    {
      InitializeComponent();
      EventBus.ChatResponseHandler += EventBus_ChatResponseHandler;
      EventBus.BrowseCompleteHandler += EventBus_BrowseCompleteHandler;
    }

    private void EventBus_BrowseCompleteHandler(object sender, TextEvent e)
    {
      RefreshContent();
    }

    public void Setup()
    {
      if (!Globals.IsInDesignMode())
      {
        timer1.Start();
        //RefreshContent();
      }
    }

    private void EventBus_ChatResponseHandler(object sender, ChatEvent e)
    {
      BeginInvoke((MethodInvoker)delegate
     {
       //string s = e.item.UserID + ":" + e.item.Text;       
       ChatListing.Items.Add(e.item);       
       ScrollToBottom();
     });
      
    }

    void ScrollToBottom()
    {
      if (AutoScroll == true)
      {
        ChatListing.TopIndex = ChatListing.Items.Count - 1;
      }
    }

    void ParseResults(string s)
    {
      if (string.IsNullOrEmpty(s)) return;
      string[] items = s.Split('\n');
      ChatListing.Items.Clear();
      foreach (string item in items)
      {
        if (string.IsNullOrEmpty(item)) continue;
        string[] bits = item.Split('|');
        if (bits.Length > 2)
        {

          string sChatObject = bits[3];

          if (!string.IsNullOrEmpty(sChatObject))
          {
            try
            {
              ChatItem ci = JsonConvert.DeserializeObject<ChatItem>(sChatObject);
              ChatListing.Items.Add(ci);              
              //ListViewItemEx lvi = new ListViewItemEx(ci.UserID + ":" + ci.Text);
              //lvi.ImageKey = "voice.ico";
              //CommentsList.Items.Add(lvi);
            }
            catch (Exception e)
            {
              Console.WriteLine(e.Message);
            }
          }
        }

      }
      ScrollToBottom();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      RefreshContent();
    }

    private void ChatList_Load(object sender, EventArgs e)
    {
     
    }

    private void ChatListing_DrawItem(object sender, DrawItemEventArgs e)
    {
      if (e.Index == -1) return;
      ChatItem ci = (ChatItem)ChatListing.Items[e.Index];
      if (string.IsNullOrEmpty(ci.Text)) return;
      ci.Text = ci.Text.Trim();
      
      e.DrawBackground();
      Image i = IconList.Images[0];

      Rectangle r = e.Bounds;
      r.Offset(0, -1);
      r.Inflate(-2, -1);
      
      e.Graphics.FillRectangle(panelbrush, r);
      e.Graphics.DrawRectangle(new Pen(Color.LightGray, 1), r);
      e.Graphics.DrawImage(i, new Point(e.Bounds.Left+5, e.Bounds.Top+5));

      e.Graphics.DrawString(ci.UserID,
        font, textbrush,
        new Rectangle(23, e.Bounds.Top, e.Bounds.Width - 22, e.Bounds.Height),
        StringFormat.GenericDefault);

      e.Graphics.DrawString(ci.UserID + ": " + ci.Text,
        font, textbrush,
        new Rectangle(22, e.Bounds.Top, e.Bounds.Width - 22, e.Bounds.Height),                        
        StringFormat.GenericDefault);

      //Console.WriteLine(sText);
    }

    private void ChatListing_MeasureItem(object sender, MeasureItemEventArgs e)
    {
      if (e.Index == -1) return;      
      ChatItem ci = (ChatItem)ChatListing.Items[e.Index];
      if (string.IsNullOrEmpty(ci.Text)) return;
      ci.Text = ci.Text.Trim();
        Size size = new Size(ChatListing.Width-20, 60);
      SizeF resize = e.Graphics.MeasureString(ci.Text, font, size.Width, StringFormat.GenericDefault);

      e.ItemHeight = (int)(resize.Height + 16);
    }

    private void ChatListing_KeyDown(object sender, KeyEventArgs e)
    {
      
    }

    private void ChatListing_MouseDown(object sender, MouseEventArgs e)
    {
      Console.WriteLine("Down");
      Scrolling = true;
      timer1.Stop();
    }

    private void ChatListing_MouseUp(object sender, MouseEventArgs e)
    {
      Console.WriteLine("Up");
      Scrolling = false;
      timer1.Start();
    }

    private void ChatListing_MouseLeave(object sender, EventArgs e)
    {
      Console.WriteLine("Leave");
      Scrolling = false;
      timer1.Start();
    }

    private void ChatListing_MouseMove(object sender, MouseEventArgs e)
    {

    }

    private void ChatListing_DoubleClick(object sender, EventArgs e)
    {
      string sReplyTo = "Replying to:";
      if (ChatListing.SelectedItems.Count > 0)
      {        
        foreach ( ChatItem o in ChatListing.SelectedItems)
        {
          if (o == null) continue;
          sReplyTo += "> "+o.UserID + "," + o.Text + "\n";
        }
      }
      chatControl1.Insert(sReplyTo);
    }


    public void RefreshContent()
    {
      if (string.IsNullOrEmpty(Globals.CurrentURL)) return;

      string sURL = Globals.settings.ServerURL
        + "?f=gh&uid=" + Globals.UserName
        + "&url=" + Globals.CurrentURL
        + "&last=" + "123"; //last entry
      string Results = Server.Request(sURL);
      ParseResults(Results);
    }

  }
}

