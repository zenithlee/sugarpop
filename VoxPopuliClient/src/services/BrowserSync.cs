using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VoxPopuliClient.events;

namespace VoxPopuliClient.services
{
  public class BrowserSync
  {
    public const string SAFARI = "Safari";
    public const string FIREFOX = "FireFox";
    public const string CHROME = "Chrome";
    public const string CHROMIUM = "Chromium";
    public const string EDGE = "Edge";
    public const string INTERNETEXPLORER = "Internet Explorer";
    public const string INTEGRATED = "Integrated Browser";

    private struct WinText
    {
      public IntPtr hWnd;
      public string Text;
    }

    const int WM_GETTEXT = 0x0D;
    const int WM_GETTEXTLENGTH = 0x0E;

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern int SendMessage(IntPtr hWnd, int msg, int Param, System.Text.StringBuilder text);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);


    public static void BrowseTo(string sURL)
    {
     // if (Globals.InCompactMode == true)
      {
        if (Globals.settings.Browser == "FireFox")
        {
          try
          {
            Process.Start(@"""C:\Program Files (x86)\Mozilla Firefox\firefox.exe""", sURL);
          }
          catch (Exception ex)
          {
            EventBus.Stats(ex.Message);
          }
        }
        else
        if (Globals.settings.Browser == BrowserSync.SAFARI)
        {
          try
          {
            Process.Start(@"/Applications/safari.app/contents/macos/Safari", sURL);
          }
          catch (Exception ex)
          {
            EventBus.Stats(ex.Message);
          }
        }
        else
        {
          try
          {
            Process.Start(sURL);
          }
          catch (Exception ex)
          {
            EventBus.Stats(ex.Message);
          }
        }
      }
    }

    public void GetURL()
    {
      List<WinText> windows = new List<WinText>();

      //find the "first" window
      IntPtr hWnd = FindWindow("MozillaWindowClass", null);

      while (hWnd != IntPtr.Zero)
      {
        //find the control window that has the text
        IntPtr hEdit = FindWindowEx(hWnd, IntPtr.Zero, "edit", null);

        //initialize the buffer.  using a StringBuilder here
        System.Text.StringBuilder sb = new System.Text.StringBuilder(255);  // or length from call with GETTEXTLENGTH

        //get the text from the child control
        int RetVal = SendMessage(hEdit, WM_GETTEXT, sb.Capacity, sb);

        windows.Add(new WinText() { hWnd = hWnd, Text = sb.ToString() });

        //find the next window
        hWnd = FindWindowEx(IntPtr.Zero, hWnd, "MozillaWindowClass", null);
      }

      //do something clever
      windows.OrderBy(x => x.Text).ToList().ForEach(y => Console.Write("{0} = {1}\n", y.hWnd, y.Text));

    }
  }
}