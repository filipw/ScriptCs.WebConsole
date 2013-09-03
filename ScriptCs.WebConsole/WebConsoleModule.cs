using System;
using ScriptCs.Contracts;

namespace ScriptCs.WebConsole
{
    [Module("webconsole")]
    public class WebConsoleModule : IModule
    {
        public void Initialize(IModuleConfiguration config)
        {
            Console.WriteLine("Web console initialized!");
            config.Console<SignalRConsole>();
        }
    }
}