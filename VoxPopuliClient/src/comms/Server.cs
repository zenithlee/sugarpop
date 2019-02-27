using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuliClient.comms
{
  public class Server
  {
    public static string Request(string sURL)
    {
      try
      {
        using (WebClient client = new WebClient())
        {
          return client.DownloadString(new Uri(sURL));
        }
      }
      catch (WebException ex)
      {
        //MessageBox.Show("Error while receiving data from the server:\n" + ex.Message, "Something broke.. :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        Console.WriteLine("Server.Request :\n" + ex.Message);
        return null;
      }
    }
  }
}
