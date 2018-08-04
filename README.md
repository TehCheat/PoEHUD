PoeHud
======

CURRENTLY DETECTED - USE AT YOUR OWN RISK
=========================================

Warnings are currently going out for HUD users. Using this can and likely will get you banned.

Reads data from Path of Exile client application and displays it on transparent overlay, while you play PoE.
Without writing to it so no map hack, disabling particles, zoom hack, fullbright.

### Donation Info
Donations can be made [here](https://www.paypal.me/TehCheat)

### Keyboard Info

* Press F12 to show / hide the Menu
* Press F9 to show / hide Item Mods
* Hold F10 to hide all huds
* Press F5 to refresh the current area.

### Available features

* Item Filter Parser - working with any item filter
* Health bars
* Icons on minimap & large map
* Item drop alerts & sounds
* Latency & fps info
* Advenced tooltip: item level, item mods, weapon DPS
* Monster alerts
* XP per hours
* XP lvl & party penalty
* Preload alerts
* DPS meter
* Floating combat display
* Monster kill counter with session
* Inventory preview
* Sound volume controls
* Highly customizable menu

### Item alert settings

The file config/crafting_bases.txt has the following syntax:
`Name,[Level],[Quality],[Rarity1,[Rarity2,[Rarity3]]]`
 - now it's best to use the Item Filter Parser
 
Examples of valid declarations:
```
Vaal Regalia,78
Corsair Sword,78,10
Gold Ring,75,,Normal,Rare
Ironscale Gauntlets,,10,Normal,Magic
Quicksilver Flask,1,5
Portal Scroll
Iron Ring
```
Also the mods used for mobs and items are listed in Content.ggpk\Data\Mods.dat.

### Before build
```
git submodule update --init --recursive
```

### Requirements

* Require Microsoft C++ Redistributable
* .NET framerwork v.4.6 or newer (you already have it on Windows 8+)
* Windows Vista or newer (XP won't work)
* Path of Exile should be running in Windowed or Windowed Fullscreen mode (the pure Fullscreen mode does not let PoeHUD draw anything over the game window)
* Windows Aero transparency effects must be enabled. (If you get a black screen this is the issue)
* DirectX 9 redistributable.
