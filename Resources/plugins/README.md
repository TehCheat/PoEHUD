1) Create a folder MyPlugin(for example) for your plugin in "plugins" directory (will contain your compiled dll).
2) Create a new project in visual studio as "Class Library" in MyPlugin folder (later this new project folder in MyPlugin directory can be renamed to "src").
3) Go to project properties, set:
    a) Application->Target framework: ".NET Framework 4.6.2"
    b) Build->Output Path: "..\..\" (without brackets) (your dll file will be copied to MyPlugin folder)
4) Add reference to PoeHUD.exe (it can be with other name) and set "Copy local: false" in properties.
5) Optional: (but required for Line/Box drawing) add four SharpDX. dll's in "PoEHUD64\lib" directory (also set "Copy local: false" in properties).
5) Create a class, add "using PoeHUD.Plugins;" at the top, and inherit it from "BasePlugin" 
or (better way) from "BaseSettingsPlugin<MySettings>" if your plugin need some settings to save or to be disabled in menu, where "MySettings" is your class for options inherited from "SettingsBase" (see example below).
6) Do your stuff by overriding functions from base class.

Everything other is the same as PoEHUD programming.

####Notes:
Use carefully the class constructor in your code, errors from it can't be handled and logged! (use Initialise function instead)
Don't forget to turn on your plugin in PoeHUD menu, otherwice it will not be rendered.
Detailed information about errors that was occurred in plugin you can found in ErrorsLog.txt in your plugin folder.

#####Functions to override:
* `Initialise` - called once on program start (even if plugin is not enabled in menu). Use it for initialising variables etc., instead of class constructor;
* `Render` - called each render frame (loop). 
* `EntityAdded(EntityWrapper entityWrapper` - called when some new entity found in memory
* `EntityRemoved(EntityWrapper entityWrapper)` - called when some entity removed from memory
* `OnClose` - called once on program close.

#####Properties:
* `PluginDirectory` - directory of dll file (for example: C:\PoEHUD\plugins\MyPlugin). Can be used for saving some files for plugin (PluginDirectory + "\\" + MyFilePath)
* `LocalPluginDirectory` - local directory of dll file (for example: plugins\MyPlugin).
* `GameController` - all the data from game holded by PoeHUD.
* `Graphics` - for drawing lines/boxes.
* `Memory` - for reading from memory
* `PluginName` - used for displaying plugin name in errors (default value: GetType().Name(from plugin Type name), can be changed).
* `PluginErrorDisplayTime` - handled error display time in seconds (default value: 3, can be changed, but not recommended).
* `AllowRender` - used for disabling rendering if plugin is disabled in menu (bAllowRender -> Settings.Enable). Can be overrided (but not recommended);

#####Functions:
* `LogMessage or LogError(string message, float displayTime)` - used for displaying information (debug) with different colors. LogError WILL NOT log it to error log file. To render text with custom color use: PoeHUD.DebugPlug.DebugPlugin.LogMsg(string message, float displayTime, SharpDX.Color).

#####Settings:
To make a settings class for "BaseSettingsPlugin<>" just make a class inherited from "SettingsBase". 
To add some options to PoeHUD menu use "Menu" attribute. 

###Example:

```c#
using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using SharpDX;

public class MySettings : SettingsBase
{
    public MySettings() // Don't forget to initialise setting nodes in settings constructor
    {
        Enable = false;
        AutoUpdate = true;
        Scale = new RangeNode<float>(20, 0, 100);
        MyColor = new Color(255, 0, 0, 255); // or Color.Red
    }
  
    [Menu("Auto Update")]
    public ToggleNode AutoUpdate { get; set; }
  
    [Menu("My Scale")]
    public RangeNode<float> Scale { get; set; }
  
    [Menu("My Color")]
    public ColorNode MyColor { get; set; }
  
    [Menu("Some text")]
    public EmptyNode empty { get; set; } // Used only for simple text in menu without functionality. Even no need to initialise it in settings constructor;
}
```

Check existing sources of other plugins for more examples.
