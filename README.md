# SteamPlaceholder [![Build status](https://ci.appveyor.com/api/projects/status/y315rvdlio5tp8yi)](https://ci.appveyor.com/project/Walkman100/steamplaceholder)
A program that you can point [Steam](http://store.steampowered.com/) to, that will start User-specified programs/games. Launch with `hideGUI` command to start minimised.

[![Gitter](https://badges.gitter.im/Join Chat.svg)](https://gitter.im/Walkman100/Walkman?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

### Screenshot
[![Example & Screenshot][Screenshot]][Screenshot]
  [Screenshot]: http://walkman100.github.io/images/Screenshots/My_Projects/SteamPlaceholder/MainWindow.png

You can launch a folder, you can use Forwardslashes `/` instead of the default backslash `\`, and you can enclose the entire string in double quotes `"`. To use this with Steam, see [this screenshot](http://walkman100.github.io/images/Screenshots/My_Projects/SteamPlaceholder/ScreenshotExample.png) from v1.

# Compatibility with Steam's game overlay:
The `GameOverlayUI.exe` process that launches and attaches to games & programs launched through Steam doesn't show on this program, but if it was started through Steam, the Steam overlay will attach to any programs that are started from it. This can be both a good thing and a bad thing:

I developed this program because I have a game that crashes if it is opened from Steam, presumably since it doesn't support the Steam overlay. If I start my game from this app after it has been launched from Steam, the game will crash, so I have to start it seperately from this app.

It can be a good thing since if you replace the executable of a Steam game with this app (don't delete the original exe), and use it as e.g. a mod launcher, so you can pick which one you want with the Steam overlay still functional.

## Donate
[Show your support!](http://walkman100.github.io/Walkman/HTML/Donate.html)


[![Bitdeli Badge](https://d2weczhvl823v0.cloudfront.net/Walkman100/steamplaceholder/trend.png)](https://bitdeli.com/free "Bitdeli Badge")

