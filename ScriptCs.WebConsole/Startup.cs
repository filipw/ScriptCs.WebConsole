using Microsoft.AspNet.SignalR;
using Owin;

namespace ScriptCs.WebConsole
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration { EnableJavaScriptProxies = true, EnableJSONP = true };
            app.MapSignalR(config);
        }
    }
}