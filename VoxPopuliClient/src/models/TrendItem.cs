using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuliClient.models
{
  public class TrendItem
  {
    private string uRL;
    private string description;
    private DateTime date;

    public string URL { get => uRL; set => uRL = value; }
    public string Description { get => description; set => description = value; }
    public DateTime Date { get => date; set => date = value; }
  }
}
