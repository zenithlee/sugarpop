using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuliClient.events
{
  public class BooleanEvent : EventArgs
  {
    public bool value;
    public BooleanEvent(bool inBool)
    {
      value = inBool;
    }
  }
}
