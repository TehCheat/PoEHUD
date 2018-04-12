using System;
using SharpDX.Direct3D9;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Settings;
using PoeHUD.Models.Enums;
using PoeHUD.Plugins;
using PoeHUD.Poe;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.EntityComponents;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Poe.FilesInMemory;
using System.Windows.Forms;
using ImGuiNET;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiVector4 = System.Numerics.Vector4;
using Vector2 = System.Numerics.Vector2;
using PoeHUD.Hud.PluginExtension;
using PoeHUD.Controllers;
using PoeHUD.Hud.UI;
using PoeHUD.Plugins;
using PoeHUD.Hud.Menu.SettingsDrawers;
using System.Text.RegularExpressions;
using System.Linq;
using Newtonsoft.Json;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Settings;
using System.Collections.Generic;
using System.IO;
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

namespace PoeHUD.Hud.Themes
{
    public class ThemeEditor : PluginHolder
    {
        public const string ThemeExtension = ".hudtheme";
        public const string DefaultThemeName = "Default";
        private const string ThemesFolder = "config/themes";

        private ThemeConfig LoadedTheme;

        public ThemeEditor() : base("ThemeEditor")
        {
            GenerateDefaultTheme();

            if (!Directory.Exists(ThemesFolder))
            {
                Directory.CreateDirectory(ThemesFolder);
                var defaultTheme = GenerateDefaultTheme();
                SaveTheme(defaultTheme, DefaultThemeName);
                MainMenuWindow.Settings.Theme.Value = DefaultThemeName;
            }

            LoadThemeFilesList();
            SelectedThemeName = MainMenuWindow.Settings.Theme.Value;
            ApplyTheme(SelectedThemeName);
            MainMenuWindow.Settings.Theme.OnValueSelected += delegate (string newThemeName) { ApplyTheme(newThemeName); };
        }

        private void LoadThemeFilesList()
        {
            var fi = new DirectoryInfo(ThemesFolder);
            MainMenuWindow.Settings.Theme.Values = fi.GetFiles($"*{ThemeExtension}").Select(x => Path.GetFileNameWithoutExtension(x.Name)).ToList();
        }


        private string SelectedThemeName;
        private string NewThemeName = "MyNewTheme";

        internal override void DrawSettingsMenu()
        {
            #region
            var newSelectedTheme = ImGuiExtension.ComboBox("Select Theme", "Themes", SelectedThemeName, MainMenuWindow.Settings.Theme.Values);
            if(SelectedThemeName != newSelectedTheme)
            {
                SelectedThemeName = newSelectedTheme;
                LoadedTheme = LoadTheme(newSelectedTheme, false);
                ApplyTheme(LoadedTheme);
            }
            if (ImGuiExtension.Button("Save current theme settings to selected"))
            {
                var currentThemeNew = ReadThemeFromCurrent();
                SaveTheme(currentThemeNew, SelectedThemeName);
            }

            ImGui.Text("");
            NewThemeName = ImGuiExtension.InputText("New theme name", NewThemeName, 200, InputTextFlags.Default);
           
            if (ImGuiExtension.Button("Create new theme from current"))
            {
                if (!string.IsNullOrEmpty(NewThemeName))
                {
                    string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                    Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                    NewThemeName = r.Replace(NewThemeName, "");

                    var currentThemeNew = ReadThemeFromCurrent();
                    SaveTheme(currentThemeNew, NewThemeName);
                    SelectedThemeName = NewThemeName;
                    LoadThemeFilesList();
                }
            }
            #endregion
            ImGui.Text("");
            
            var style = ImGui.GetStyle();

            if (ImGui.TreeNode("Theme settings"))
            {
                style.AntiAliasedFill = DrawBoolSetting("AntiAliasedFill", style.AntiAliasedFill);
                style.AntiAliasedLines = DrawBoolSetting("AntiAliasedLines", style.AntiAliasedLines);

                style.Alpha = DrawFloatSetting("Alpha", style.Alpha * 100, 0, 100) / 100f;

                style.DisplayWindowPadding = DrawVectorSetting("DisplayWindowPadding", style.DisplayWindowPadding, 0, 20);
                style.TouchExtraPadding = DrawVectorSetting("TouchExtraPadding", style.TouchExtraPadding, 0, 10);
                style.WindowPadding = DrawVectorSetting("WindowPadding", style.WindowPadding, 0, 20);
                style.FramePadding = DrawVectorSetting("FramePadding", style.FramePadding, 0, 20);
                style.DisplaySafeAreaPadding = DrawVectorSetting("DisplaySafeAreaPadding", style.DisplaySafeAreaPadding, 0, 20);

                style.ItemInnerSpacing = DrawVectorSetting("ItemInnerSpacing", style.ItemInnerSpacing, 0, 20);
                style.ItemSpacing = DrawVectorSetting("ItemSpacing", style.ItemSpacing, 0, 20);

                style.GrabMinSize = DrawFloatSetting("GrabMinSize", style.GrabMinSize, 0, 20);
                style.GrabRounding = DrawFloatSetting("GrabRounding", style.GrabRounding, 0, 12);
                style.IndentSpacing = DrawFloatSetting("IndentSpacing", style.IndentSpacing, 0, 30);

                style.ScrollbarRounding = DrawFloatSetting("ScrollbarRounding", style.ScrollbarRounding, 0, 19);
                style.ScrollbarSize = DrawFloatSetting("ScrollbarSize", style.ScrollbarSize, 0, 20);

                style.WindowTitleAlign = DrawVectorSetting("WindowTitleAlign", style.WindowTitleAlign, 0, 1, 0.1f);
                style.WindowRounding = DrawFloatSetting("WindowRounding", style.WindowRounding, 0, 14);
                style.ChildWindowRounding = DrawFloatSetting("ChildWindowRounding", style.ChildWindowRounding, 0, 16);
                style.FrameRounding = DrawFloatSetting("FrameRounding", style.FrameRounding, 0, 12);
                style.ColumnsMinSpacing = DrawFloatSetting("ColumnsMinSpacing", style.ColumnsMinSpacing, 0, 30);

                style.CurveTessellationTolerance = DrawFloatSetting("CurveTessellationTolerance", style.CurveTessellationTolerance * 100, 0, 100) / 100;
            }

            ImGui.Text("");
            #region ColorsDraw
            ImGui.Text("Colors:");
            ImGui.Columns(2, "Columns", true);
      
            var colorTypes = Enum.GetValues(typeof(ColorTarget)).Cast<ColorTarget>();
            var count = colorTypes.Count() / 2;

            foreach (var type in colorTypes)
            {
                var nameFixed = Regex.Replace(type.ToString(), "(\\B[A-Z])", " $1");
                var colorValue = style.GetColor(type);

                if (ImGui.ColorEdit4(nameFixed, ref colorValue, ColorEditFlags.AlphaBar | ColorEditFlags.NoInputs | ColorEditFlags.AlphaPreviewHalf))
                    style.SetColor(type, colorValue);

                if (count-- == -1)
                    ImGui.NextColumn();
            }
            #endregion
        }

        private bool DrawBoolSetting(string name, bool result)
        {
            ImGui.Checkbox(name, ref result);
            return result;
        }
        private float DrawFloatSetting(string name, float result, float min, float max, float power = 1)
        {
            ImGui.SliderFloat(name, ref result, min, max, "%.0f", power);
            return result;
        }

        private Vector2 DrawVectorSetting(string name, Vector2 result, float min, float max, float power = 1)
        {
            ImGui.SliderVector2(name, ref result, min, max, "%.0f", power);
            return result;
        }

        public static void ApplyTheme(string fileName)
        {
            var theme = LoadTheme(fileName, true);

            if(theme == null)
            {
                BasePlugin.LogMessage($"Can't find theme file {fileName}, loading default.", 3);
                theme = LoadTheme(DefaultThemeName, true);
                if(theme == null)
                {
                    BasePlugin.LogMessage($"Can't find default theme file {DefaultThemeName}, Generating default and saving...", 3);
                    theme = GenerateDefaultTheme();
                    SaveTheme(theme, DefaultThemeName);
                }
            }
            ApplyTheme(theme);
        }

        public static void ApplyTheme(ThemeConfig theme)
        {  
            var style = ImGui.GetStyle();

            style.AntiAliasedLines = theme.AntiAliasedLines;
            style.DisplaySafeAreaPadding = theme.DisplaySafeAreaPadding;
            style.DisplayWindowPadding = theme.DisplayWindowPadding;
            style.GrabRounding = theme.GrabRounding;
            style.GrabMinSize = theme.GrabMinSize;
            style.ScrollbarRounding = theme.ScrollbarRounding;
            style.ScrollbarSize = theme.ScrollbarSize;
            style.ColumnsMinSpacing = theme.ColumnsMinSpacing;
            style.IndentSpacing = theme.IndentSpacing;
            style.TouchExtraPadding = theme.TouchExtraPadding;
            style.ItemInnerSpacing = theme.ItemInnerSpacing;
         
            style.ItemSpacing = theme.ItemSpacing;
            style.FrameRounding = theme.FrameRounding;
            style.FramePadding = theme.FramePadding;
            style.ChildWindowRounding = theme.ChildWindowRounding;
            style.WindowTitleAlign = theme.WindowTitleAlign;
            style.WindowRounding = theme.WindowRounding;
            //style.WindowMinSize = theme.WindowMinSize;
            style.WindowPadding = theme.WindowPadding;
            style.Alpha = theme.Alpha;
            style.AntiAliasedFill = theme.AntiAliasedFill;
            style.CurveTessellationTolerance = theme.CurveTessellationTolerance;

       
            foreach (var color in theme.Colors)
            {
                try
                {
                    if(color.Key == ColorTarget.Count)//This shit made a crash
                        continue;
                    style.SetColor(color.Key, color.Value);
                }
                catch (Exception ex) { BasePlugin.LogError(ex.Message, 5); }

            }
        }
        private ThemeConfig ReadThemeFromCurrent()
        {
            var style = ImGui.GetStyle();
            var result = new ThemeConfig();
            result.AntiAliasedLines = style.AntiAliasedLines;
            result.DisplaySafeAreaPadding = style.DisplaySafeAreaPadding;
            result.DisplayWindowPadding = style.DisplayWindowPadding;
            result.GrabRounding = style.GrabRounding;
            result.GrabMinSize = style.GrabMinSize;
            result.ScrollbarRounding = style.ScrollbarRounding;
            result.ScrollbarSize = style.ScrollbarSize;
            result.ColumnsMinSpacing = style.ColumnsMinSpacing;
            result.IndentSpacing = style.IndentSpacing;
            result.TouchExtraPadding = style.TouchExtraPadding;
            result.ItemInnerSpacing = style.ItemInnerSpacing;
            result.ItemSpacing = style.ItemSpacing;
            result.FrameRounding = style.FrameRounding;
            result.FramePadding = style.FramePadding;
            result.ChildWindowRounding = style.ChildWindowRounding;
            result.WindowTitleAlign = style.WindowTitleAlign;
            result.WindowRounding = style.WindowRounding;
            //result.WindowMinSize = style.WindowMinSize;
            result.WindowPadding = style.WindowPadding;
            result.Alpha = style.Alpha;
            result.AntiAliasedFill = style.AntiAliasedFill;
            result.CurveTessellationTolerance = style.CurveTessellationTolerance;

            var colorTypeValues = Enum.GetValues(typeof(ColorTarget)).Cast<ColorTarget>();
            //Read colors
            foreach (var colorType in colorTypeValues)
            {
                if (colorType == ColorTarget.Count)//This shit made a crash
                    continue;
                result.Colors.Add(colorType, style.GetColor(colorType));
            }

            return result;
        }

        private static ThemeConfig GenerateDefaultTheme()
        {
            var resultTheme = new ThemeConfig();
            resultTheme.Colors.Add(ColorTarget.Text, new ImGuiVector4(0.90f, 0.90f, 0.90f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.TextDisabled, new ImGuiVector4(0.60f, 0.60f, 0.60f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.WindowBg, new ImGuiVector4(0.16f, 0.16f, 0.16f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.ChildBg, new ImGuiVector4(0.12f, 0.12f, 0.12f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.PopupBg, new ImGuiVector4(0.11f, 0.11f, 0.14f, 0.92f));
            resultTheme.Colors.Add(ColorTarget.Border, new ImGuiVector4(0.44f, 0.44f, 0.44f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.BorderShadow, new ImGuiVector4(0.00f, 0.00f, 0.00f, 0.00f));
            resultTheme.Colors.Add(ColorTarget.FrameBg, new ImGuiVector4(0.20f, 0.20f, 0.20f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.FrameBgHovered, new ImGuiVector4(0.98f, 0.61f, 0.26f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.FrameBgActive, new ImGuiVector4(0.74f, 0.36f, 0.02f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.TitleBg, new ImGuiVector4(0.40f, 0.19f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.TitleBgActive, new ImGuiVector4(0.74f, 0.36f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.TitleBgCollapsed, new ImGuiVector4(0.75f, 0.37f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.MenuBarBg, new ImGuiVector4(0.29f, 0.29f, 0.30f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.ScrollbarBg, new ImGuiVector4(0.28f, 0.28f, 0.28f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.ScrollbarGrab, new ImGuiVector4(0.71f, 0.37f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.ScrollbarGrabHovered, new ImGuiVector4(0.86f, 0.41f, 0.06f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.ScrollbarGrabActive, new ImGuiVector4(0.64f, 0.29f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.CheckMark, new ImGuiVector4(0.96f, 0.45f, 0.01f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.SliderGrab, new ImGuiVector4(0.86f, 0.48f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.SliderGrabActive, new ImGuiVector4(0.52f, 0.31f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.Button, new ImGuiVector4(0.73f, 0.37f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.ButtonHovered, new ImGuiVector4(0.97f, 0.57f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.ButtonActive, new ImGuiVector4(0.62f, 0.29f, 0.01f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.Header, new ImGuiVector4(0.59f, 0.28f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.HeaderHovered, new ImGuiVector4(0.74f, 0.35f, 0.02f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.HeaderActive, new ImGuiVector4(0.88f, 0.45f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.Separator, new ImGuiVector4(0.50f, 0.50f, 0.50f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.SeparatorHovered, new ImGuiVector4(0.60f, 0.60f, 0.70f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.SeparatorActive, new ImGuiVector4(0.70f, 0.70f, 0.90f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.ResizeGrip, new ImGuiVector4(1.00f, 1.00f, 1.00f, 0.16f));
            resultTheme.Colors.Add(ColorTarget.ResizeGripHovered, new ImGuiVector4(0.78f, 0.82f, 1.00f, 0.60f));
            resultTheme.Colors.Add(ColorTarget.ResizeGripActive, new ImGuiVector4(0.78f, 0.82f, 1.00f, 0.90f));
            resultTheme.Colors.Add(ColorTarget.CloseButton, new ImGuiVector4(0.50f, 0.50f, 0.90f, 0.50f));
            resultTheme.Colors.Add(ColorTarget.CloseButtonHovered, new ImGuiVector4(0.70f, 0.70f, 0.90f, 0.60f));
            resultTheme.Colors.Add(ColorTarget.CloseButtonActive, new ImGuiVector4(0.70f, 0.70f, 0.70f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.PlotLines, new ImGuiVector4(1.00f, 1.00f, 1.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.PlotLinesHovered, new ImGuiVector4(0.90f, 0.70f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.PlotHistogram, new ImGuiVector4(0.90f, 0.70f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.PlotHistogramHovered, new ImGuiVector4(1.00f, 0.60f, 0.00f, 1.00f));
            resultTheme.Colors.Add(ColorTarget.TextSelectedBg, new ImGuiVector4(1.00f, 0.03f, 0.03f, 0.35f));
            resultTheme.Colors.Add(ColorTarget.ModalWindowDarkening, new ImGuiVector4(0.20f, 0.20f, 0.20f, 0.35f));
            resultTheme.Colors.Add(ColorTarget.DragDropTarget, new ImGuiVector4(1.00f, 1.00f, 0.00f, 0.90f));
            return resultTheme;
        }

        #region SaveLoad
        private static ThemeConfig LoadTheme(string fileName, bool nullIfNotFound)
        {
            ThemeConfig result;
            try
            {
                var fullPath = Path.Combine(ThemesFolder, fileName + ThemeExtension);
                if (File.Exists(fullPath))
                {
                    string json = File.ReadAllText(fullPath);
                    return JsonConvert.DeserializeObject<ThemeConfig>(json, SettingsHub.jsonSettings);
                }
            }
            catch (Exception ex)
            {
                BasePlugin.LogError($"Error while loading theme {fileName}: {ex.Message}, Generating default one", 3);
            }
            if (nullIfNotFound)
                return null;
            return GenerateDefaultTheme();
        }

        private static void SaveTheme(ThemeConfig theme, string fileName)
        {
            try
            {
                var fullPath = Path.Combine(ThemesFolder, fileName + ThemeExtension);
                var settingsDirName = Path.GetDirectoryName(fullPath);
                if (!Directory.Exists(settingsDirName))
                    Directory.CreateDirectory(settingsDirName);

                using (var stream = new StreamWriter(File.Create(fullPath)))
                {
                    string json = JsonConvert.SerializeObject(theme, Formatting.Indented, SettingsHub.jsonSettings);
                    stream.Write(json);
                }
            }
            catch (Exception ex)
            {
                BasePlugin.LogError($"Error while loading theme: {ex.Message}", 3);
            }
        }
        #endregion

    }
}

/*
     //
     // Summary:
     //     Enable anti-aliasing on lines/borders. Disable if you are really tight on CPU/GPU.
     public ToggleNode AntiAliasedLines { get; set; } = true;
     //
     // Summary:
     //     If you cannot see the edge of your screen (e.g. on a TV) increase the safe area
     //     padding. Covers popups/tooltips as well regular windows.
     //Have no idea what the fuck is this
     public RangeNode<Vector2> DisplaySafeAreaPadding { get; set; } = new RangeNode<Vector2>(Vector2.One * 8, Vector2.Zero, Vector2.One * 20);
     //
     // Summary:
     //     Window positions are clamped to be visible within the display area by at least
     //     this amount. Only covers regular windows.
     public RangeNode<Vector2> DisplayWindowPadding { get; set; } = new RangeNode<Vector2>(Vector2.One * 8, Vector2.Zero, Vector2.One * 20);
     //
     // Summary:
     //     Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.
     public RangeNode<float> GrabRounding { get; set; } = new RangeNode<float>(0, 0, 12);
     //
     // Summary:
     //     Minimum width/height of a grab box for slider/scrollbar
     public RangeNode<float> GrabMinSize { get; set; } = new RangeNode<float>(10, 0, 20);
     //
     // Summary:
     //     Radius of grab corners for scrollbar
     public RangeNode<float> ScrollbarRounding { get; set; } = new RangeNode<float>(9, 0, 19);
     //
     // Summary:
     //     Width of the vertical scrollbar, Height of the horizontal scrollbar
     public RangeNode<float> ScrollbarSize { get; set; } = new RangeNode<float>(16, 0, 20);
     //
     // Summary:
     //     Minimum horizontal spacing between two columns
     public RangeNode<float> ColumnsMinSpacing { get; set; } = new RangeNode<float>(21, 0, 30);

     //
     // Summary:
     //     Horizontal indentation when e.g. entering a tree node
     public RangeNode<float> IndentSpacing { get; set; } = new RangeNode<float>(21, 0, 30);
     //
     // Summary:
     //     Expand reactive bounding box for touch-based system where touch position is not
     //     accurate enough. Unfortunately we don't sort widgets so priority on overlap will
     //     always be given to the first widget. So don't grow this too much!
     public RangeNode<Vector2> TouchExtraPadding { get; set; } = new RangeNode<Vector2>(Vector2.Zero, Vector2.Zero, Vector2.One * 10);
     //
     // Summary:
     //     Horizontal and vertical spacing between within elements of a composed widget
     //     (e.g. a slider and its label).
     public RangeNode<Vector2> ItemInnerSpacing { get; set; } = new RangeNode<Vector2>(Vector2.One * 4, Vector2.Zero, Vector2.One * 20);
     //
     // Summary:
     //     Horizontal and vertical spacing between widgets/lines.
     public RangeNode<Vector2> ItemSpacing { get; set; } = new RangeNode<Vector2>(new ImGuiVector2(8, 4), Vector2.Zero, Vector2.One * 20);
     //
     // Summary:
     //     Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used
     //     by most widgets).
     public RangeNode<float> FrameRounding { get; set; } = new RangeNode<float>(0, 0, 12);
     //
     // Summary:
     //     Padding within a framed rectangle (used by most widgets).
     public RangeNode<Vector2> FramePadding { get; set; } = new RangeNode<Vector2>(new ImGuiVector2(4, 3), Vector2.Zero, Vector2.One * 20);
     //
     // Summary:
     //     Radius of child window corners rounding. Set to 0.0f to have rectangular windows.
     public RangeNode<float> ChildWindowRounding { get; set; } = new RangeNode<float>(0, 0, 16);
     //
     // Summary:
     //     Alignment for title bar text.
     public RangeNode<Vector2> WindowTitleAlign { get; set; } = new RangeNode<Vector2>(Vector2.One * 0.5f, Vector2.Zero, Vector2.One);
     //
     // Summary:
     //     Radius of window corners rounding. Set to 0.0f to have rectangular windows.
     public RangeNode<float> WindowRounding { get; set; } = new RangeNode<float>(7, 0, 14);
     //
     // Summary:
     //     Minimum window size.
     //public RangeNode<Vector2> WindowMinSize { get; set; } = new RangeNode<float>(10, 0, 500);
     //
     // Summary:
     //     Padding within a window.
     public RangeNode<Vector2> WindowPadding { get; set; } = new RangeNode<Vector2>(Vector2.One * 8, Vector2.Zero, Vector2.One * 20);
     //
     // Summary:
     //     Global alpha applies to everything in ImGui.
     public RangeNode<float> Alpha { get; set; } = new RangeNode<float>(1, 0, 1);
     //
     // Summary:
     //     Enable anti-aliasing on filled shapes (rounded rectangles, circles, etc.)
     public ToggleNode AntiAliasedFill { get; set; } = true; 
     //
     // Summary:
     //     Tessellation tolerance. Decrease for highly tessellated curves (higher quality,
     //     more polygons), increase to reduce quality.
     public RangeNode<float> CurveTessellationTolerance { get; set; } = new RangeNode<float>(1, 0, 1);
     */
