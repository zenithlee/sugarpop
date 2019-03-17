using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxLib
{
  public class Tools
  {
    public static string SendChat(ChatItem c, string ServerURL, string UserName, string CurrentURL)
    {
      string sChatData = JsonConvert.SerializeObject(c);

      string sURL = ServerURL
        + "?f=mc&uid=" + UserName
        + "&co=" + sChatData
        + "&url=" + CurrentURL;
      string Result = Server.Request(sURL);
      return Result;
    }
  }
}
