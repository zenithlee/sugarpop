using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoxPopuliClient.src
{
  public class Globals
  {    
    public static Settings settings;
    public static string CurrentURL = "http://bigfun.co.za/pop/?version=0.21";
    public static string UserName = "Anon";

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
