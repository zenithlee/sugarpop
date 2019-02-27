using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxPopuliClient.models;

namespace VoxPopuliClient.events
{
  public class ChatEvent
  {
    public ChatItem item;
    public ChatEvent(ChatItem inItem)
    {
      item = inItem;
    }
  }
}
