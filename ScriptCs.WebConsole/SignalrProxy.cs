using System;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ScriptCs.WebConsole
{
    [HubName("console")]
    public class SignalrProxy : Hub
    {
        public static string UserLine = null;

        public void UserInput(string message)
        {
            UserLine = message;
        }
    }
}
