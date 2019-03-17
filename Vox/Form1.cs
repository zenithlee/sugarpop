using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vox.src;
using VoxLib;

namespace Vox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void TestButton_Click(object sender, EventArgs e)
    {
      string sData = Server.Request("http://a.4cdn.org/pol/catalog.json");
      Parse(sData);
    }

    void Parse(string sData)
    {
      List<RootObject> lro = JsonConvert.DeserializeObject<List<RootObject>>(sData);

      StringBuilder sb = new StringBuilder();

      foreach( RootObject ro in lro)
      {
        foreach( src.Thread t in ro.threads)
        {
          string sCom = t.com;          
          if (string.IsNullOrEmpty(sCom)) continue;
          if (t.sticky == 1) continue;

          sCom = sCom.Replace("<wbr>", "");
          sCom = sCom.Replace("<b>", "");
          sCom = sCom.Replace("</b>", "");

          Regex reg = new Regex(@"htt.?.:.+?[( <)]");
          Match m = reg.Match(sCom);
          if ( m.Success == true)
          {
            string mv = m.Value;
            mv = mv.TrimEnd(new char[] { '<' });
            mv = mv.TrimEnd();
            sb.Append(t.sub + "\r\n");
            sb.Append(mv + "\r\n");
            sb.Append(t.com + "\r\n-----------------------------\r\n");
            Add(mv, t.sub, "politik");
          }          
        }
      }

      DataBox.AppendText(sb.ToString());

    }

    void Add(string sURL, string sTitle, string sChannel)
    {
      ChatItem chat = new ChatItem()
      {
        Text = sTitle,
        Channel = sChannel,
        UserID = "Anon",
        UserGUID = "VOX1",
        time = DateTime.Now.ToUniversalTime(),
        Attachments = ""
      };

      Tools.SendChat(chat, "http://bigfun.co.za/pop/", "Vox1", sURL);
    }
  }
}
