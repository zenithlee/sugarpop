using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuliClient.src
{
  public class Settings
  {
    private static string SettingsFile = "settings.dat";

    private string serverMessage = "";
    private string serverURL = "http://bigfun.co.za/pop/";
    public string ServerURL { get => serverURL; set => serverURL = value; }
    public string ServerMessage { get => serverMessage; set => serverMessage = value; }

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
      return settings;
    }

    public void Save()
    {
      if (!Directory.Exists("data"))
      {
        Directory.CreateDirectory("data");
      }
      string sData = JsonConvert.SerializeObject(this);
      File.WriteAllText(Path.Combine("data", SettingsFile), sData);
    }
  }
}
