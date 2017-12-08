using Newtonsoft.Json;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Settings;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using MenuItem = PoeHUD.Hud.Menu.MenuItem;

namespace PoeHUD.Plugins
{
    public class BaseSettingsPlugin<TSettings> : BasePlugin where TSettings : SettingsBase, new()
    {
        public TSettings Settings { get; private set; }
        private string SettingsFileName = "config.ini";
        public MenuItem PluginSettingsRootMenu { get; private set; }

        public BaseSettingsPlugin()
        {
            eSaveSettings += SaveSettings;
            eLoadSettings += LoadSettings;
        }

        private string SettingsFullPath
        {
            get { return PluginDirectory + "\\" + SettingsFileName; }
        }

        private void LoadSettings()
        {
            try
            {
                var settingsFullPath = SettingsFullPath;

                if (File.Exists(settingsFullPath))
                {
                    string json = File.ReadAllText(settingsFullPath);
                    Settings = JsonConvert.DeserializeObject<TSettings>(json, SettingsHub.jsonSettings);
                }

                if (Settings == null)//...also sometimes config contains only "null" word, so that will be a fix for that
                    Settings = new TSettings();
            }
            catch
            {
                LogError($"Plugin {PluginName} error load settings!", 3);
                Settings = new TSettings();
            }

            if (Settings.Enable == null)
                Settings.Enable = false;
            if (!GameController.pluginsSettings.TryGetValue(SettingsFileName, out _))
            {
                GameController.pluginsSettings.Add(Settings.ToString().Split('.')[0],Settings);
            }
        }

        private void SaveSettings()
        {
            try
            {
                var settingsDirName = Path.GetDirectoryName(SettingsFullPath);
                if (!Directory.Exists(settingsDirName))
                    Directory.CreateDirectory(settingsDirName);

                using (var stream = new StreamWriter(File.Create(SettingsFullPath)))
                {
                    string json = JsonConvert.SerializeObject(Settings, Formatting.Indented, SettingsHub.jsonSettings);
                    stream.Write(json);
                }
            }
            catch
            {
                LogError($"Plugin {PluginName} error save settings!", 3);
            }
        }

        public override bool bAllowRender
        {
            get
            {
                return Settings.Enable;
            }
        }

        public override void InitialiseMenu(MenuItem mainMenu)
        {
            PluginSettingsRootMenu = MenuPlugin.AddChild(mainMenu, PluginName, Settings.Enable);
            var settingsProps = Settings.GetType().GetProperties();

            Dictionary<int, MenuItem> RootMenu = new Dictionary<int, MenuItem>();

            foreach (var property in settingsProps)
            {
                var menuAttrib = property.GetCustomAttribute<MenuAttribute>();

                MenuItem parentMenu = PluginSettingsRootMenu;

                if (menuAttrib != null)
                {
                    if (menuAttrib.parentIndex != -1)
                    {
                        if (RootMenu.ContainsKey(menuAttrib.parentIndex))
                            parentMenu = RootMenu[menuAttrib.parentIndex];
                        else
                            LogError($"{PluginName}: Can't find parent menu with index '{menuAttrib.parentIndex}'!", 5);
                    }

                    MenuItem resultItem = null;

                    var propType = property.PropertyType;

                    if (propType == typeof(ToggleNode) || propType.IsSubclassOf(typeof(ToggleNode)))
                    {
                        ToggleNode option = property.GetValue(Settings) as ToggleNode;
                        resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                    }
                    else if (propType == typeof(ColorNode) || propType.IsSubclassOf(typeof(ColorNode)))
                    {
                        ColorNode option = property.GetValue(Settings) as ColorNode;
                        resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                    }
                    else if (propType == typeof(EmptyNode) || propType.IsSubclassOf(typeof(EmptyNode)))
                    {
                        resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName);
                    }
                    else if (propType == typeof(HotkeyNode) || propType.IsSubclassOf(typeof(HotkeyNode)))
                    {
                        HotkeyNode option = property.GetValue(Settings) as HotkeyNode;
                        resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                    }
                    else if (propType == typeof(ButtonNode) || propType.IsSubclassOf(typeof(ButtonNode)))
                    {
                        ButtonNode option = property.GetValue(Settings) as ButtonNode;
                        resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                    }
                    else if (propType == typeof(ListNode) || propType.IsSubclassOf(typeof(ListNode)))
                    {
                        ListNode option = property.GetValue(Settings) as ListNode;
                        var listButton = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                        resultItem = listButton;
                    }
                    else if (propType.IsGenericType)
                    {
                        //Actually we can use reflection to find correct method in MenuPlugin by argument types and invoke it, but I don't have enough time for this way..
                        /*
                        var method = typeof(MenuPlugin).GetMethods();
                        method.ToList().Find(x => x.Name == "AddChild");
                        */

                        var genericType = propType.GetGenericTypeDefinition();

                        if (genericType == typeof(RangeNode<>))
                        {
                            var genericParameter = propType.GenericTypeArguments;

                            if (genericParameter.Length > 0)
                            {
                                var argType = genericParameter[0];

                                if (argType == typeof(int))
                                {
                                    RangeNode<int> option = property.GetValue(Settings) as RangeNode<int>;
                                    resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(float))
                                {
                                    RangeNode<float> option = property.GetValue(Settings) as RangeNode<float>;
                                    resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(double))
                                {
                                    RangeNode<double> option = property.GetValue(Settings) as RangeNode<double>;
                                    resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(byte))
                                {
                                    RangeNode<byte> option = property.GetValue(Settings) as RangeNode<byte>;
                                    resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(long))
                                {
                                    RangeNode<long> option = property.GetValue(Settings) as RangeNode<long>;
                                    resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(short))
                                {
                                    RangeNode<short> option = property.GetValue(Settings) as RangeNode<short>;
                                    resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(ushort))
                                {
                                    RangeNode<ushort> option = property.GetValue(Settings) as RangeNode<ushort>;
                                    resultItem = MenuPlugin.AddChild(parentMenu, menuAttrib.MenuName, option);
                                }
                                else
                                    LogError($"{PluginName}: Generic node argument for range node '{argType.Name}' is not defined in code. Range node type: " + propType.Name, 5);
                            }
                            else
                                LogError($"{PluginName}: Can't get GenericTypeArguments from option type: " + propType.Name, 5);
                        }
                        else
                            LogError($"{PluginName}: Generic option node is not defined in code: " + genericType.Name, 5);

                    }
                    else
                        LogError($"{PluginName}: Type of option node is not defined: " + propType.Name, 5);


                    if (resultItem != null)
                    {
                        resultItem.TooltipText = menuAttrib.Tooltip;

                        if (menuAttrib.index != -1)
                        {
                            if (!RootMenu.ContainsKey(menuAttrib.index))
                            {
                                RootMenu.Add(menuAttrib.index, resultItem);
                            }
                            else
                            {
                                LogError($"{PluginName}: Can't add menu '{menuAttrib.MenuName}', plugin already contains menu with index '{menuAttrib.index}'!", 5);
                            }
                        }
                    }
                }
            }
        }


    }
}