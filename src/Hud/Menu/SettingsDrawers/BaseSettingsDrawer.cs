using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Hud;
using PoeHUD.Hud.UI;
using PoeHUD.Hud.Settings;
using ImGuiNET;
using System.IO;
using PoeHUD.Controllers;
using Vector2 = System.Numerics.Vector2;

namespace PoeHUD.Hud.Menu.SettingsDrawers
{
    public class BaseSettingsDrawer
    {
        [Obsolete("Use BaseSettingsDrawer(string settingName, int settingId) to avoid problems with drawing. Use GetUniqDrawerId() for SettingId")]
        public BaseSettingsDrawer() { }
        [Obsolete("Use BaseSettingsDrawer(string settingName, int settingId) to avoid problems with drawing. Use GetUniqDrawerId() for SettingId")]
        public BaseSettingsDrawer(string settingName) { SettingName = settingName; }
        public BaseSettingsDrawer(string settingName, int settingId) { SettingName = settingName; SettingId = settingId; }

        public int SettingId { get; set; } = -1;
        public string SettingName { get; set; } = "#NONAME#";
        public string SettingTooltip { get; set; } = "";

        public Func<bool> IsVisibleFunc = delegate { return true; };

        internal string ImguiUniqLabel => $"{SettingName}##{SettingId}";

        public virtual void Draw() => ImGuiExtension.Label(SettingName);

        public void DrawWithTooltip()
        {
            Draw();
            if (!string.IsNullOrEmpty(SettingTooltip))
            {
                ImGuiExtension.ToolTip(SettingTooltip);
            }
        }

        public readonly List<BaseSettingsDrawer> Children = new List<BaseSettingsDrawer>();
        internal float ChildHeight;
        internal float ChildLabelWidthMax;
    }

    //Label (EmptyNode)
    public class LabelSettingDrawer : BaseSettingsDrawer
    {
        [Obsolete()]
        public LabelSettingDrawer() { }
        public LabelSettingDrawer(string settingName, int settingId) : base(settingName, settingId) { }
        public override void Draw() => ImGuiExtension.Label(SettingName);
    }

    public class SameLineSettingDrawer : BaseSettingsDrawer
    {
        public SameLineSettingDrawer() { }
        [Obsolete("Use constructor without parameters")]
        public SameLineSettingDrawer(string settingName, int settingId) : base(settingName, settingId) { }
        public override void Draw() => ImGui.SameLine();
    }

    //Button
    public class ButtonSettingDrawer : BaseSettingsDrawer
    {
        [Obsolete()]
        public ButtonSettingDrawer() { }
        public ButtonSettingDrawer(ButtonNode button, string settingName, int settingId) : base(settingName, settingId) => Button = button;
        public ButtonNode Button;
        public ButtonSettingDrawer(ButtonNode button) => Button = button;

        public override void Draw()
        {
            if (ImGuiExtension.Button(ImguiUniqLabel)) Button.OnPressed();
        }
    }

    public class HotkeySettingDrawer : BaseSettingsDrawer
    {
        public HotkeyNode Hotkey;
        [Obsolete()]
        public HotkeySettingDrawer(HotkeyNode hotkey) => Hotkey = hotkey;
        public HotkeySettingDrawer(HotkeyNode hotkey, string settingName, int settingId) : base(settingName, settingId) => Hotkey = hotkey;

        public override void Draw()
        {
            var oldValue = ImGuiExtension.HotkeySelector(ImguiUniqLabel, Hotkey.Value);

            if (Hotkey.Value != oldValue)
            {
                Hotkey.Value = oldValue;
                try { Hotkey.OnValueChanged?.Invoke(); }
                catch (Exception ex) { DebugPlug.DebugPlugin.LogMsg("Error while invoking OnValueChanged in HotkeyNode", 5); }
            }
        }
    }

    public class CheckboxSettingDrawer : BaseSettingsDrawer
    {
        public ToggleNode Toggle;
        [Obsolete()]
        public CheckboxSettingDrawer(ToggleNode toggle) => Toggle = toggle;
        public CheckboxSettingDrawer(ToggleNode toggle, string settingName, int settingId) : base(settingName, settingId) => Toggle = toggle;

        public override void Draw()
        {
            Toggle.Value = ImGuiExtension.Checkbox(ImguiUniqLabel, Toggle.Value);
        }
    }

    public class ColorSettingDrawer : BaseSettingsDrawer
    {
        public ColorNode Color;
        [Obsolete()]
        public ColorSettingDrawer(ColorNode color) => Color = color;
        public ColorSettingDrawer(ColorNode color, string settingName, int settingId) : base(settingName, settingId) => Color = color;
        public override void Draw()
        {
            Color.Value = ImGuiExtension.ColorPicker(ImguiUniqLabel, Color.Value);
        }
    }


    public class ComboBoxSettingDrawer : BaseSettingsDrawer
    {
        public ListNode List;
        [Obsolete()]
        public ComboBoxSettingDrawer(ListNode list) => List = list;
        public ComboBoxSettingDrawer(ListNode list, string settingName, int settingId) : base(settingName, settingId) => List = list;
        public override void Draw()
        {
            List.Value = ImGuiExtension.ComboBox(ImguiUniqLabel, SettingName, List.Value, List.Values);
        }
    }


    public class CustomSettingsDrawer : BaseSettingsDrawer
    {
        public Action DrawDelegate = delegate { ImGuiExtension.Label($"Not implemented in code. Set DrawDelegate to draw own code."); };

        public override void Draw()
        {
            try
            {
                DrawDelegate();
            }
            catch (Exception e)
            {
                DebugPlug.DebugPlugin.LogMsg("Error in CustomSettingsDrawer.DrawDelegate: " + e.Message, 5, SharpDX.Color.Red);
            }
        }
    }

    public class IntegerSettingsDrawer : BaseSettingsDrawer
    {
        public RangeNode<int> IntegerNode;
        [Obsolete()]
        public IntegerSettingsDrawer(RangeNode<int> node) => IntegerNode = node;
        public IntegerSettingsDrawer(RangeNode<int> node, string settingName, int settingId) : base(settingName, settingId) => IntegerNode = node;
        public override void Draw()
        {
            IntegerNode.Value = ImGuiExtension.IntSlider(ImguiUniqLabel, IntegerNode.Value, IntegerNode.Min, IntegerNode.Max);
        }
    }

    public class FloatSettingsDrawer : BaseSettingsDrawer
    {
        public RangeNode<float> IntegerNode;
        public FloatSettingsDrawer(RangeNode<float> node, string settingName, int settingId) : base(settingName, settingId) => IntegerNode = node;
        public override void Draw()
        {
            IntegerNode.Value = ImGuiExtension.FloatSlider(ImguiUniqLabel, IntegerNode.Value, IntegerNode.Min, IntegerNode.Max);
        }
    }

    public class TextSettingDrawer : BaseSettingsDrawer
    {
        public TextNode Toggle;
        public TextSettingDrawer(TextNode toggle, string settingName, int settingId) : base(settingName, settingId) => Toggle = toggle;

        public override void Draw()
        {
            Toggle.Value = ImGuiExtension.InputText(ImguiUniqLabel, Toggle.Value, 500, InputTextFlags.Default);
        }
    }

    public class StashTabNodeSettingDrawer : BaseSettingsDrawer
    {
        public StashTabNode StashNode;
        [Obsolete()]
        public StashTabNodeSettingDrawer(StashTabNode stashNode) => StashNode = stashNode;
        public StashTabNodeSettingDrawer(StashTabNode stashNode, string settingName, int settingId) : base(settingName, settingId) => StashNode = stashNode;

        public override void Draw()
        {
            var selectedIndex = StashNode.Exist ? StashNode.VisibleIndex : -1;

            if (ImGui.Button($"x##{SettingName}{SettingId}ClearButton"))
            {
                StashNode.Name = StashTabNode.EMPTYNAME;
                StashNode.VisibleIndex = -1;
                StashNode.Id = -1;
                StashNode.Exist = false;
            }
            ImGui.SameLine();

            if (MainMenuWindow.Settings.DeveloperMode.Value)
            {
                ImGuiExtension.Label($"Ex:{StashNode.Exist}, Ind:{StashNode.VisibleIndex}, Id:{StashNode.Id}, Name: {StashNode.Name}");
                ImGui.SameLine();
            }

            if (ImGui.Combo(ImguiUniqLabel, ref selectedIndex, StashTabController.StashTabNames, StashTabController.StashTabNames.Length * 20))
            {
                var node = StashTabController.GetStashTabNodeByVisibleIndex(selectedIndex);
                StashNode.Name = node.Name;
                StashNode.VisibleIndex = node.VisibleIndex;
                StashNode.Id = node.Id;
                StashNode.Exist = true;
                StashNode.IsRemoveOnly = node.IsRemoveOnly;
            }
        }
    }

    public class FilePickerDrawer : BaseSettingsDrawer
    {
        public FileNode FNode;
        public FilePickerDrawer(FileNode fNode)
        {
            FNode = fNode;
            var documentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            CurrentFolder = Path.Combine(documentsPath, @"My Games\Path of Exile");
            SelectedFile = FNode.Value;
        }

        public override void Draw()
        {
            if (ImGui.TreeNode(ImguiUniqLabel))
            {
                var selected = FNode.Value;
                if (DrawFolder(ref selected))
                {
                    FNode.Value = selected;
                }
            }
        }

        public string CurrentFolder { get; set; }
        public string SelectedFile { get; set; }
        private bool DrawFolder(ref string selected)
        {
            bool result = false;
            ImGui.Text("Current Folder: " + CurrentFolder);
            if (ImGui.BeginChildFrame(1, new Vector2(0, 300), WindowFlags.Default))
            {
                DirectoryInfo di = new DirectoryInfo(CurrentFolder);
                if (di.Exists)
                {
                    if (di.Parent != null)
                    {
                        ImGui.PushStyleColor(ColorTarget.Text, new System.Numerics.Vector4(1, 1, 0, 1));
                        if (ImGui.Selectable("../", false, SelectableFlags.DontClosePopups))
                        {
                            CurrentFolder = di.Parent.FullName;
                        }
                        ImGui.PopStyleColor();
                    }

                    foreach (var dict in di.GetDirectories())
                    {
                        ImGui.PushStyleColor(ColorTarget.Text, new System.Numerics.Vector4(1, 1, 0, 1));
                        if (ImGui.Selectable(dict.Name + "/", false, SelectableFlags.DontClosePopups))
                        {
                            CurrentFolder = dict.FullName;
                        }
                        ImGui.PopStyleColor();
                    }

                    foreach (var file in di.GetFiles("*.filter"))
                    {
                        bool isSelected = SelectedFile == file.FullName;
                        if (ImGui.Selectable(file.Name, isSelected, SelectableFlags.DontClosePopups))
                        {
                            selected = SelectedFile;
                            SelectedFile = file.FullName;
                            result = true;
                        }
                    }
                }
            }
            ImGui.EndChildFrame();
            return result;
        }
    }
}