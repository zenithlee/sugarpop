using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuliClient
{
  public class Settings
  {
    private string gUID = "";
    private static string SettingsFile = "settings.dat";
    private string screenName = "Anon";
    private bool startInCompactMode = false;
    private bool stayOnTop = false;
    private string serverMessage = "";
    private string serverURL = "http://bigfun.co.za/vox/";
    public string Browser = "Default";

    public string ServerURL {
      get
      {
        return serverURL;
        //#if DEBUG
        //      return "http://localhost:7057/";        
        //#endif
      }
      set => serverURL = value;
    }
    public string ServerMessage { get => serverMessage; set => serverMessage = value; }
    public bool StartInCompactMode { get => startInCompactMode; set => startInCompactMode = value; }
    public string ScreenName { get => screenName; set => screenName = value; }
    public string GUID { get => gUID; set => gUID = value; }
    public bool StayOnTop { get => stayOnTop; set => stayOnTop = value; }

    public static Settings Load()
    {
      if (!Directory.Exists("data"))
      {
        Directory.CreateDirectory("data");
      }

      Settings settings = null;
      if (!File.Exists(Path.Combine("data",SettingsFile)))
      {
        settings = new Settings();
      }
      else
      {
        string sData = File.ReadAllText(Path.Combine("data", SettingsFile));
        settings = JsonConvert.DeserializeObject<Settings>(sData);
      }

      if (string.IsNullOrEmpty(settings.GUID))
      {
        settings.GUID = Guid.NewGuid().ToString();
        settings.Save();
      }

      return settings;
    }

    public void Save()
    {
      if (string.IsNullOrEmpty(GUID))
      {
        GUID = Guid.NewGuid().ToString();
      }

      if (!Directory.Exists("data"))
      {
        Directory.CreateDirectory("data");
      }
      string sData = JsonConvert.SerializeObject(this);
      File.WriteAllText(Path.Combine("data", SettingsFile), sData);
    }
  }
}
