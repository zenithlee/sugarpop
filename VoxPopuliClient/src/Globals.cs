using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.models;

namespace VoxPopuliClient
{
  public class Globals
  {
    public static Settings settings;
    
    public static string CurrentTitle = "";
    public static string CurrentURL = "http://bigfun.co.za/vox/?version=0.26";    
    public static string UserName = "Anon";
    public static bool InCompactMode = false;

    public static bool IsInDesignMode()
    {
      if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
      {
        return true;
      }
      return false;
    }

  }
}
