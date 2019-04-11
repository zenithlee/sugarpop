using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuliClient.comms
{
  public class Server
  {

    public static string Post(string sURL, Dictionary<string, string> parms)
    {      
      NameValueCollection namedc = new NameValueCollection();
      foreach (KeyValuePair<string, string> kv in parms)
      {
        namedc.Add(kv.Key, kv.Value);        
      }

      try
      {
        using (WebClient client = new WebClient())
        {
          client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
          byte[] responsebytes = client.UploadValues(sURL, "POST", namedc);
          return Encoding.UTF8.GetString(responsebytes);      
        }
      }
      catch (WebException ex)
      {
        //MessageBox.Show("Error while receiving data from the server:\n" + ex.Message, "Something broke.. :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        Console.WriteLine("Server.Request :\n" + ex.Message);
        return null;
      }
    }
    public static string Request(string sURL)
    {     
      
      try
      {
        using (WebClient client = new WebClient())
        {          
          string HtmlResult = client.DownloadString(sURL);          
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
