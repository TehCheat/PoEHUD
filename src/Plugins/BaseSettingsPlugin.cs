using ImGuiNET;
using Newtonsoft.Json;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using SharpDX;
using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.PluginExtension;
using PoeHUD.Models;
using System;
using System.IO;
using Graphics = PoeHUD.Hud.UI.Graphics;

namespace PoeHUD.Plugins
{
    public class BaseSettingsPlugin<TSettings> : BasePlugin where TSettings : SettingsBase, new()
    {
        internal override bool _allowRender => Settings.Enable.Value;

        #region Settings
        public TSettings Settings { get; private set; }
        private string SettingsFileName = "config.ini";
        private bool MenuInitialized { get; set; }
        private MenuItem RootMenu { get; set; }

<<<<<<< HEAD
        public BaseSettingsPlugin()
        {
            eSaveSettings += SaveSettings;
            eLoadSettings += LoadSettings;
        }

        private class MenuItem
        {
            public int Index { get; set; } = 1;
            public PropertyInfo Property { get; set; } = null;
            public string TooltipText { get; set; } = null;
            public Action ItemRender { get; set; } = () => { };
            public List<MenuItem> Children { get; set; } = new List<MenuItem>();

            public void RenderWithChildren()
            {
                if (Children != null && Children.Count > 0)
                {
                    if (Property == null)
                    {
                        Children?.OrderBy(x => x.Index).ToList().ForEach(x => x.RenderWithChildren());
                    }
                    else
                    {
                        var menuAttrib = Property.GetCustomAttribute<MenuAttribute>();

                        var treeName = Property.Name;
                        if (menuAttrib != null)
                        {
                            treeName = menuAttrib.MenuName;
                        }

                        if (ImGui.TreeNode(menuAttrib.MenuName))
                        {
                            ItemRender();
                            Children?.OrderBy(x => x.Index).ToList().ForEach(x => x.RenderWithChildren());
                            ImGui.TreePop();
                        }
                    } 
                }
                else
                {
                    ItemRender();
                }
            }
        }

        public override void RenderMenu()
        {
            if (!MenuInitialized)
                InitializeMenu();

            ImGui.Text(this.PluginName);
            ImGui.Spacing();

            Settings.Enable = ImGuiExtension.Checkbox("Enable", Settings.Enable);
            ImGui.Spacing();

            RootMenu.RenderWithChildren();
        }

        private void InitializeMenu()
        {
            var settingsProps = Settings.GetType().GetProperties();

            RootMenu = new MenuItem();

            Dictionary<int, MenuItem> MenuItems = new Dictionary<int, MenuItem>();

            foreach (var property in settingsProps)
            {
                var menuAttrib = property.GetCustomAttribute<MenuAttribute>();

                MenuItem parentMenu = RootMenu;

                if (menuAttrib != null)
                {
                    if (menuAttrib.parentIndex != -1)
                    {
                        if (MenuItems.TryGetValue(menuAttrib.parentIndex, out MenuItem parentItem))
                        {
                            parentMenu = parentItem;
                        }
                        else
                            LogError($"{PluginName}: Can't find parent menu with index '{menuAttrib.parentIndex}'!", 5);
                    }

                    MenuItem resultItem = null;

                    var propType = property.PropertyType;

                    if (propType == typeof(ToggleNode) || propType.IsSubclassOf(typeof(ToggleNode)))
                    {
                        ToggleNode option = property.GetValue(Settings) as ToggleNode;

                        resultItem = new MenuItem();
                        resultItem.ItemRender = () => option.Value = ImGuiExtension.Checkbox(menuAttrib.MenuName, option);
                    }
                    else if (propType == typeof(ColorNode) || propType.IsSubclassOf(typeof(ColorNode)))
                    {
                        ColorNode option = property.GetValue(Settings) as ColorNode;

                        resultItem = new MenuItem();
                        resultItem.ItemRender = () => ImGui.TextDisabled("Unimplemented ColorNode");

                    }
                    else if (propType == typeof(EmptyNode) || propType.IsSubclassOf(typeof(EmptyNode)))
                    {
                        resultItem = new MenuItem();
                    }
                    else if (propType == typeof(HotkeyNode) || propType.IsSubclassOf(typeof(HotkeyNode)))
                    {
                        HotkeyNode option = property.GetValue(Settings) as HotkeyNode;

                        resultItem = new MenuItem();
                        resultItem.ItemRender = () => option.Value = ImGuiExtension.HotkeySelector(menuAttrib.MenuName, option);
                    }
                    else if (propType == typeof(ButtonNode) || propType.IsSubclassOf(typeof(ButtonNode)))
                    {
                        ButtonNode option = property.GetValue(Settings) as ButtonNode;

                        resultItem = new MenuItem();
                        resultItem.ItemRender = () => ImGui.TextDisabled("Unimplemented ButtonNode");
                    }
                    else if (propType == typeof(ListNode) || propType.IsSubclassOf(typeof(ListNode)))
                    {
                        ListNode option = property.GetValue(Settings) as ListNode;

                        resultItem = new MenuItem();
                        // TODO: Is this right? I know ListNodes are weird.
                        resultItem.ItemRender = () => option.Value = ImGuiExtension.ComboBox(menuAttrib.MenuName, option.Value, option.Value.Split(',').ToList());
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

                                    resultItem = new MenuItem();
                                    resultItem.ItemRender = () => option.Value = ImGuiExtension.IntSlider(menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(float))
                                {
                                    RangeNode<float> option = property.GetValue(Settings) as RangeNode<float>;

                                    resultItem = new MenuItem();
                                    resultItem.ItemRender = () => option.Value = ImGuiExtension.FloatSlider(menuAttrib.MenuName, option);
                                }
                                else if (argType == typeof(double))
                                {
                                    RangeNode<double> option = property.GetValue(Settings) as RangeNode<double>;

                                    resultItem = new MenuItem();
                                    resultItem.ItemRender = () => option.Value = ImGuiExtension.FloatSlider(menuAttrib.MenuName, (float)option.Value, (float)option.Min, (float)option.Max);
                                }
                                else if (argType == typeof(byte))
                                {
                                    RangeNode<byte> option = property.GetValue(Settings) as RangeNode<byte>;

                                    resultItem = new MenuItem();
                                    resultItem.ItemRender = () => option.Value = (byte)ImGuiExtension.IntSlider(menuAttrib.MenuName, (int)option.Value, (int)option.Min, (int)option.Max);
                                }
                                else if (argType == typeof(long))
                                {
                                    RangeNode<long> option = property.GetValue(Settings) as RangeNode<long>;

                                    resultItem = new MenuItem();
                                    resultItem.ItemRender = () => option.Value = (long)ImGuiExtension.IntSlider(menuAttrib.MenuName, (int)option.Value, (int)option.Min, (int)option.Max);
                                }
                                else if (argType == typeof(short))
                                {
                                    RangeNode<short> option = property.GetValue(Settings) as RangeNode<short>;

                                    resultItem = new MenuItem();
                                    resultItem.ItemRender = () => option.Value = (short)ImGuiExtension.IntSlider(menuAttrib.MenuName, (int)option.Value, (int)option.Min, (int)option.Max);
                                }
                                else if (argType == typeof(ushort))
                                {
                                    RangeNode<ushort> option = property.GetValue(Settings) as RangeNode<ushort>;

                                    resultItem = new MenuItem();
                                    resultItem.ItemRender = () => option.Value = (ushort)ImGuiExtension.IntSlider(menuAttrib.MenuName, (int)option.Value, (int)option.Min, (int)option.Max);
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
                        parentMenu.Children.Add(resultItem);

                        resultItem.Property = property;
                        resultItem.Index = menuAttrib.index;
                        resultItem.TooltipText = menuAttrib.Tooltip;

                        if (menuAttrib.index != -1)
                        {
                            if (!MenuItems.ContainsKey(menuAttrib.index))
                            {
                                MenuItems.Add(menuAttrib.index, resultItem);
                            }
                            else
                            {
                                LogError($"{PluginName}: Can't add menu '{menuAttrib.MenuName}', plugin already contains menu with index '{menuAttrib.index}'!", 5);
                            }
                        }
                    }
                }
            }

            MenuInitialized = true;
        }

        private string SettingsFullPath
        {
            get { return PluginDirectory + "\\" + SettingsFileName; }
        }
=======
        private string SettingsFullPath => PluginDirectory + "\\" + SettingsFileName;
>>>>>>> a69f31c5cb975407a3afee9dfedc990145a7cf51

        internal override void _LoadSettings()
        {
            try
            {
                var settingsFullPath = SettingsFullPath;

                if (File.Exists(settingsFullPath))
                {
                    string json = File.ReadAllText(settingsFullPath);
                    Settings = JsonConvert.DeserializeObject<TSettings>(json, SettingsHub.jsonSettings);
                }

                if (Settings == null)
                    Settings = new TSettings();
            }
            catch
            {
                LogError($"Plugin {PluginName} error load settings!", 3);
                Settings = new TSettings();
            }

            if (Settings.Enable == null)//...also sometimes config Enable contains only "null" word, so that will be a fix for that
                Settings.Enable = false;


            if (GameController.pluginsSettings.ContainsKey(SettingsFullPath))//For hot reload
            {
                GameController.pluginsSettings.Remove(SettingsFullPath);
            }

            GameController.pluginsSettings.Add(SettingsFullPath, Settings);
        }

        internal override void SaveSettings()
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
        #endregion
    }
}