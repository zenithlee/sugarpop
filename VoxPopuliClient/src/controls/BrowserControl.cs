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
using System.Reflection;

namespace VoxPopuliClient.src.controls
{
  public partial class BrowserControl : UserControl
  {
    public BrowserControl()
    {
      InitializeComponent();
      EventBus.BrowseToHandler += EventBus_BrowseToHandler;
      EventBus.NavigateBackHandler += EventBus_NavigateBackHandler;
      EventBus.NavigateForwardHandler += EventBus_NavigateForwardHandler;
    }

    private void EventBus_NavigateForwardHandler(object sender, TextEvent e)
    {
      if (Globals.InCompactMode == true) return;
      webBrowser1.GoForward();
    }

    private void EventBus_NavigateBackHandler(object sender, TextEvent e)
    {
      if (Globals.InCompactMode == true) return;
      webBrowser1.GoBack();
    }

    //tries to find a title for the current page
    void FindTitle()
    {
      string Title = webBrowser1.Document.Title;
      Globals.CurrentTitle = Title;
    }

    private void EventBus_BrowseToHandler(object sender, TextEvent e)
    {
      if (Globals.InCompactMode == true) return;
      /// Enabled = false; //prevent browser from stealing focus    
      try
      {
        string url = e.Text;
        if (url.Contains("youtube"))
        {
          if (url.Contains("?"))
          {
            url += "&html5=1";
          }
          else
          {
            url += "?html5=1";
          }

        }

        webBrowser1.Url = new Uri(url);
      }
      catch (Exception ex)
      {
        EventBus.Stats(ex.Message);
      }
    }


    void Download(string URL)
    {

    }

    private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
    {
      //Enabled = false; //prevent browser from stealing focus  

      if (webBrowser1.Url != null)
      {
        Console.WriteLine("Navigating" + webBrowser1.Url.AbsoluteUri);
      }
    }

    private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
    {
      // Enabled = true;
      if (webBrowser1.Url != null)
      {
        Globals.CurrentURL = webBrowser1.Url.AbsoluteUri;
        EventBus.URLChanged(Globals.CurrentURL);
        Console.WriteLine("Navigated" + webBrowser1.Url.AbsoluteUri);
      }

    }

    private void BrowserControl_Click(object sender, EventArgs e)
    {
      //Enabled = true;
    }

    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      ///Enabled = true;
      webBrowser1.ScriptErrorsSuppressed = true;

      this.webBrowser1.Document.Body.MouseDown -= Body_MouseDown;
      this.webBrowser1.Document.Body.MouseDown += Body_MouseDown;
      EventBus.BrowseComplete(webBrowser1.Url.AbsoluteUri);
      EventBus.Stats("Loaded:" + e.Url);
      FindTitle();
    }

    private void Body_MouseDown(object sender, HtmlElementEventArgs e)
    {
      switch (e.MouseButtonsPressed)
      {
        case MouseButtons.Left:
          //HtmlElement element = this.webBrowser1.Document.GetElementFromPoint(e.ClientMousePosition);
          //if (element != null && "submit".Equals(element.GetAttribute("type"), StringComparison.OrdinalIgnoreCase))
          //{
          //}
          break;
      }
    }
  }
}
