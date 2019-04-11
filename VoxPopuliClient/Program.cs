using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoxPopuliClient.forms;

namespace VoxPopuliClient
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      if ( !Directory.Exists("data"))
      {
        Directory.CreateDirectory("data");
      }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
#if MAC
      Application.Run(new MacMain());
#else
        Application.Run(new MacMain());
#endif
    
    }
  }
}
