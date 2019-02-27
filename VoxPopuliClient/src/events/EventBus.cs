using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxPopuliClient.models;

namespace VoxPopuliClient.events
{
  public class EventBus
  {
    public static event EventHandler<TextEvent> URLChangedHandler;
    public static event EventHandler<TextEvent> BrowseToHandler;
    public static event EventHandler<ChatEvent> ChatResponseHandler;
    public static event EventHandler<TextEvent> StatusHandler;
    public static event EventHandler<TextEvent> NavigateBackHandler;
    public static event EventHandler<TextEvent> NavigateForwardHandler;

    public static void NavigateBack(string s)
    {
      NavigateBackHandler?.Invoke(null, new TextEvent(""));
    }
    public static void NavigateForward(string s)
    {
      NavigateForwardHandler?.Invoke(null, new TextEvent(""));
    }

    public static void URLChanged(string sURL)
    {
      URLChangedHandler?.Invoke(null, new TextEvent(sURL));
    }

    public static void ChatResponse(ChatItem ci)
    {
      ChatResponseHandler?.Invoke(null, new ChatEvent(ci));
    }

    public static void BrowseTo(string sURL)
    {
      BrowseToHandler?.Invoke(null, new TextEvent(sURL));
    }

    public static void Stats(string s)
    {
      StatusHandler?.Invoke(null, new TextEvent(s));
    }
  }
}
