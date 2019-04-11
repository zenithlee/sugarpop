using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Using a key
/// Mashes text into other text
/// Unmashes text
/// </summary>
namespace VoxPopuliClient
{
  public class Mash
  {
    public static string EnMash(string key, string input)
    {
      if (string.IsNullOrEmpty(key)) key = "123";
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < input.Length; i++)
        sb.Append((char)(input[i] ^ key[(i % key.Length)]));
      String result = sb.ToString();

      return result;
    }
    public static string UnMash(string key, string input)
    {
      if (string.IsNullOrEmpty(key)) key = "123";
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < input.Length; i++)
        sb.Append((char)(input[i] ^ key[(i % key.Length)]));
      String result = sb.ToString();

      return result;
    }
  }
}
