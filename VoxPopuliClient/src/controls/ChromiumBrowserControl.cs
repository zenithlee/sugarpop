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

namespace VoxPopuliClient.src.controls
{
  public partial class ChromiumBrowserControl : UserControl
  {
    //ChromiumWebBrowser _browser = null;
    public ChromiumBrowserControl()
    {
      InitializeComponent();
      //_browser = new ChromiumWebBrowser("http://google.com");
      //this.Controls.Add(_browser);
      EventBus.BrowseToHandler += EventBus_BrowseToHandler;
     
    }

    public void Setup()
    {
      //CefSettings settings = new CefSettings();
     // Cef.Initialize(settings);
      //_browser = new ChromiumWebBrowser("http://google.com");
      //this.Controls.Add(_browser);
      //_browser.Dock = DockStyle.Fill;
    }

    private void EventBus_BrowseToHandler(object sender, TextEvent e)
    {
     // if (_browser == null) return;
      //try
      //{        
      //  _browser.Load(e.Text);
        //ChromiumBrowser.  .Url = new Uri(e.Text);
      //}
     // catch (Exception ex)
     // {
     //   EventBus.Stats(ex.Message);
     // }
    }

    private void ChromiumBrowserControl_Load(object sender, EventArgs e)
    {
      
    }
  }
}
