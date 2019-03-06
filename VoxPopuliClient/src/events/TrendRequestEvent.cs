using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuliClient.events
{
  public class TrendRequestEvent : EventArgs
  {
    public bool Show;
    public TrendRequestEvent(bool b)
    {
      Show = b;
    }
  }
}
