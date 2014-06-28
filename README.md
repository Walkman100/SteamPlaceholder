SteamPlaceholder
================

A program that you can point Steam to, that will start User-specified programs/games. Launch with `hideGUI` command to start minimised.

Please note that if it is passed multiple parameters that are not `hideGUI` or `hidegui`, then it will only run the last argument passed to it.

Some Examples (Screenshot):
===========================

![Example & Screenshot](http://walkman100.github.io/Walkman/Images/SteamPlaceholderScreenshotExample.png "Example & Screenshot")

This shows that you can launch a folder, you can use Forwardslashes `/` instead of the default backslash `\`, and you can enclose the entire string in double quotes `"`. This screenshot also explains how to use this with Steam.

Compatibility with Steam's game overlay:
========================================
The `GameOverlayUI.exe` process that launches and attaches to games & programs launched through Steam doesn't show on this program, but if it was started through Steam, the Steam overlay will attach to any programs that are started from it. This can be both a good thing and a bad thing:

I developed this program because I have a game that crashes if it is opened from Steam, presumably since it doesn't support the Steam overlay. If I start my game from this app after it has been launched from Steam, the game will crash, so I have to start it seperately from this app.

It can be a good thing since if you replace the executable of a Steam game with this app (don't delete the original exe), and use it as e.g. a mod launcher, so you can pick which one you want with the Steam overlay still functional.
