ScriptCs.WebConsole
===================

To get started:

1) install the nupkg from this repository as global module `scriptcs -install scriptcs.webconsole -g` - (you will have to add a private feed to your nuget config)
2) grab this build of scriptcs - https://github.com/filipw/scriptcs/tree/iconsole and build it
3) run `scriptcs.exe -modules webconsole -repl` on that build. Make sure you run with elevation. This will start the self hosted SignalR server.
4) navigate to `index.html` from the client folder of this repo
5) voila!
