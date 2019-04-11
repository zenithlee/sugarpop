using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoxPopuliClient.src.controls
{
  public partial class VChatItem : UserControl
  {
    public VChatItem()
    {
      InitializeComponent();
    }

    private string userName;

    public new string Text
    {
      get => ChatTextBox.Text;
      set { ChatTextBox.Text = value; Measure(); }
    }

    public string UserName
    {
      get => UsernameLabel.Text;
      set => UsernameLabel.Text = value;
    }

    void Measure()
    {
      Graphics g = this.CreateGraphics();

      SizeF size = g.MeasureString(Text, ChatTextBox.Font, ChatTextBox.Width);

      Height = (int)size.Height+10;
      g.Dispose();
    }
  }
}
