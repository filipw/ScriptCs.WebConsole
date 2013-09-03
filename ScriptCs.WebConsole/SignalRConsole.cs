using System;
using System.Threading;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using ScriptCs.Contracts;

namespace ScriptCs.WebConsole
{
    public class SignalRConsole : IConsole
    {
        private readonly IHubContext _hubContext;
        private static readonly object Lock = new object();

        public SignalRConsole()
        {
            var url = "http://localhost:8945";
            WebApp.Start<Startup>(url);
            System.Console.WriteLine("Server running on {0}", url);
            _hubContext = GlobalHost.ConnectionManager.GetHubContext<SignalrProxy>();
        }

        public void Write(string value)
        {
            _hubContext.Clients.All.Write(value);
        }

        public void WriteLine(string value)
        {
            _hubContext.Clients.All.WriteLine(value);
        }

        public string ReadLine()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (SignalrProxy.UserLine != null)
                {
                    lock (Lock)
                    {
                        var result = SignalrProxy.UserLine;
                        SignalrProxy.UserLine = null;
                        return result;
                    }
                }
            }
        }

        public void Exit()
        {
            _hubContext.Clients.All.Exit();
        }

        public void ResetColor()
        {
            _hubContext.Clients.All.ResetColor();
        }

        public ConsoleColor ForegroundColor
        {
            get { return ConsoleColor.White; }
            set
            {
                _hubContext.Clients.All.ConsoleColor(value);
            }
        }
    }
}