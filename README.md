ScriptCs.WebConsole
===================

To get started:

all you need is this build of scriptcs - https://github.com/filipw/scriptcs/tree/iconsole

1. get it, build

2. run `scriptcs -install scriptcs.webconsole -pre -g`. This will install web console as scriptcs global module

3. start: `scriptcs.exe -modules webconsole -repl` (it should display info that signalr server is running)

4. go to [http://scriptcs-webconsole.azurewebsites.net/](http://scriptcs-webconsole.azurewebsites.net/) and use the web console!
The website is hosted on azure but it will try to connect to your local `scriptcs.exe` (localhost:8945)
If the local `scriptcs.exe` is not running you will simply see a JS error.
