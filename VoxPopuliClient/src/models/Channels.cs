using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxPopuliClient.events;

namespace VoxPopuliClient.models
{
  public struct Channel
  {
    public string Name;
    public string Description;
    public int Count;
  }

  public class Channels
  {
    public static Channels _instance;
    public const string CHANNEL_WHATEV = "whatev";
    public const string CHANNEL_TEK = "tek";
    public const string CHANNEL_MUZAK = "muzak";
    //public const string CHANNEL_SOCKMEDIA = "sockmedia";
    public const string CHANNEL_POLITIK = "politik";
    public const string CHANNEL_TWITFACE = "twitface";
    public const string CHANNEL_GOZZIP = "gozzzip";
    public const string CHANNEL_WEIBO = "weibo";
    public const string CHANNEL_HAHA = "haha";
    public const string CHANNEL_JUNK = "junk";
    public const string CHANNEL_POP = "pop";

    public static string ChannelCurrent = CHANNEL_WHATEV;

    static Dictionary<string, Channel> _Channels = new Dictionary<string, Channel>();

    public Channels()
    {
      Add(CHANNEL_WHATEV, "All of it in one place", 0);
      Add(CHANNEL_TEK, "Hi Tek Shit", 0);
      Add(CHANNEL_MUZAK, "Musical Indoctrination and/or Meditation", 0);
      Add(CHANNEL_POLITIK, "Politiking shenanigans", 0);
      Add(CHANNEL_TWITFACE, "Sockmedia stuff",0);
      Add(CHANNEL_GOZZIP, "Banter", 0);
      Add(CHANNEL_WEIBO, "Get in here fanboys",0);
      Add(CHANNEL_HAHA, "Laugh out loud or gtfo",0);
      Add(CHANNEL_JUNK, "Random Garbage",0);
    }

    public static Channels GetInstance()
    {
      if (Channels._instance == null)
      {
        Channels._instance = new Channels();
      }
      return Channels._instance;
    }

    public string[] GetList()
    {
      List<string> Result = new List<string>();
      foreach( KeyValuePair<string,Channel> kv in _Channels)
      {
        Result.Add(kv.Key);
      }
      return Result.ToArray();
    }

    void Add(string sName, string sDescr, int nCount)
    {
      Channel c = new Channel()
      {
        Name = sName,
        Description = sDescr,
        Count = nCount
      };
      _Channels.Add(sName, c);
    }

    public string GetDescription(string sChannel)
    {
      if (!_Channels.ContainsKey(sChannel))
      {
        EventBus.Stats("Error retrieving channel " + sChannel);
        return "";
      }
      Channel c = _Channels[sChannel];
      return c.Description;
    }
  }
}
