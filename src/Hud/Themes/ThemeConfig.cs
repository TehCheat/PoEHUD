using ImGuiNET;
using Newtonsoft.Json;
using PoeHUD.Controllers;
using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Menu.SettingsDrawers;
using PoeHUD.Hud.PluginExtension;
using PoeHUD.Hud.PluginExtension;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Plugins;
using PoeHUD.Plugins;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.EntityComponents;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.IO;
using System.IO;
using System.IO;
using System.Linq;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ColorTarget = ImGuiNET.ImGuiCol;
using Graphics = PoeHUD.Hud.UI.Graphics;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiVector4 = System.Numerics.Vector4;
using Vector2 = System.Numerics.Vector2;
namespace PoeHUD.Hud.Themes
{
    public class ThemeConfig : SettingsBase
    {
        public ThemeConfig()
        {
            Enable = true;
        }

        #region ThemeSettings
        //
        // Summary:
        //     Enable anti-aliasing on lines/borders. Disable if you are really tight on CPU/GPU.
        public bool AntiAliasedLines { get; set; } = true;
        //
        // Summary:
        //     If you cannot see the edge of your screen (e.g. on a TV) increase the safe area
        //     padding. Covers popups/tooltips as well regular windows.
        public Vector2 DisplaySafeAreaPadding { get; set; } = Vector2.One * 8;
        //
        // Summary:
        //     Window positions are clamped to be visible within the display area by at least
        //     this amount. Only covers regular windows.
        public Vector2 DisplayWindowPadding { get; set; } = Vector2.One * 8;
        //
        // Summary:
        //     Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.
        public float GrabRounding { get; set; } = 0;
        //
        // Summary:
        //     Minimum width/height of a grab box for slider/scrollbar
        public float GrabMinSize { get; set; } = 10;
        //
        // Summary:
        //     Radius of grab corners for scrollbar
        public float ScrollbarRounding { get; set; } = 9;
        //
        // Summary:
        //     Width of the vertical scrollbar, Height of the horizontal scrollbar
        public float ScrollbarSize { get; set; } = 16;
        //
        // Summary:
        //     Minimum horizontal spacing between two columns
        public float ColumnsMinSpacing { get; set; } = 21;
        //
        // Summary:
        //     Horizontal indentation when e.g. entering a tree node
        public float IndentSpacing { get; set; } = 21;
        //
        // Summary:
        //     Expand reactive bounding box for touch-based system where touch position is not
        //     accurate enough. Unfortunately we don't sort widgets so priority on overlap will
        //     always be given to the first widget. So don't grow this too much!
        public Vector2 TouchExtraPadding { get; set; } = Vector2.Zero;
        //
        // Summary:
        //     Horizontal and vertical spacing between within elements of a composed widget
        //     (e.g. a slider and its label).
        public Vector2 ItemInnerSpacing { get; set; } = Vector2.One * 4;
        //
        // Summary:
        //     Horizontal and vertical spacing between widgets/lines.
        public Vector2 ItemSpacing { get; set; } = new ImGuiVector2(8, 4);
        //
        // Summary:
        //     Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used
        //     by most widgets).
        public float FrameRounding { get; set; } = 0;
        //
        // Summary:
        //     Padding within a framed rectangle (used by most widgets).
        public Vector2 FramePadding { get; set; } = new ImGuiVector2(4, 3);
        //
        // Summary:
        //     Radius of child window corners rounding. Set to 0.0f to have rectangular windows.
        public float ChildWindowRounding { get; set; } = 0;
        //
        // Summary:
        //     Alignment for title bar text.
        public Vector2 WindowTitleAlign { get; set; } = Vector2.One * 0.5f;
        //
        // Summary:
        //     Radius of window corners rounding. Set to 0.0f to have rectangular windows.
        public float WindowRounding { get; set; } = 7;
        //
        // Summary:
        //     Minimum window size.
        //public Vector2 WindowMinSize { get; set; }
        //
        // Summary:
        //     Padding within a window.
        public Vector2 WindowPadding { get; set; } = Vector2.One * 8;
        //
        // Summary:
        //     Global alpha applies to everything in ImGui.
        public float Alpha { get; set; } = 1f;
        //
        // Summary:
        //     Enable anti-aliasing on filled shapes (rounded rectangles, circles, etc.)
        public bool AntiAliasedFill { get; set; } = true;
        //
        // Summary:
        //     Tessellation tolerance. Decrease for highly tessellated curves (higher quality,
        //     more polygons), increase to reduce quality.
        public float CurveTessellationTolerance { get; set; } = 1f;
        #endregion




        public Dictionary<ColorTarget, ImGuiVector4> Colors = new Dictionary<ColorTarget, ImGuiVector4>();
    }
}




/* main
style.SetColor(ColorTarget.Text, new ImGuiVector4(0.90f, 0.90f, 0.90f, 1.00f));
            style.SetColor(ColorTarget.TextDisabled, new ImGuiVector4(0.60f, 0.60f, 0.60f, 1.00f));
            style.SetColor(ColorTarget.WindowBg, new ImGuiVector4(0.16f, 0.16f, 0.16f, 1.00f));
            style.SetColor(ColorTarget.ChildBg, new ImGuiVector4(0.12f, 0.12f, 0.12f, 1.00f));
            style.SetColor(ColorTarget.PopupBg, new ImGuiVector4(0.11f, 0.11f, 0.14f, 0.92f));
            style.SetColor(ColorTarget.Border, new ImGuiVector4(0.44f, 0.44f, 0.44f, 1.00f));
            style.SetColor(ColorTarget.BorderShadow, new ImGuiVector4(0.00f, 0.00f, 0.00f, 0.00f));
            style.SetColor(ColorTarget.FrameBg, new ImGuiVector4(0.20f, 0.20f, 0.20f, 1.00f));
            style.SetColor(ColorTarget.FrameBgHovered, new ImGuiVector4(0.98f, 0.61f, 0.26f, 1.00f));
            style.SetColor(ColorTarget.FrameBgActive, new ImGuiVector4(0.74f, 0.36f, 0.02f, 1.00f));
            style.SetColor(ColorTarget.TitleBg, new ImGuiVector4(0.40f, 0.19f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.TitleBgActive, new ImGuiVector4(0.74f, 0.36f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.TitleBgCollapsed, new ImGuiVector4(0.75f, 0.37f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.MenuBarBg, new ImGuiVector4(0.29f, 0.29f, 0.30f, 1.00f));
            style.SetColor(ColorTarget.ScrollbarBg, new ImGuiVector4(0.28f, 0.28f, 0.28f, 1.00f));
            style.SetColor(ColorTarget.ScrollbarGrab, new ImGuiVector4(0.71f, 0.37f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.ScrollbarGrabHovered, new ImGuiVector4(0.86f, 0.41f, 0.06f, 1.00f));
            style.SetColor(ColorTarget.ScrollbarGrabActive, new ImGuiVector4(0.64f, 0.29f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.CheckMark, new ImGuiVector4(0.96f, 0.45f, 0.01f, 1.00f));
            style.SetColor(ColorTarget.SliderGrab, new ImGuiVector4(0.86f, 0.48f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.SliderGrabActive, new ImGuiVector4(0.52f, 0.31f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.Button, new ImGuiVector4(0.73f, 0.37f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.97f, 0.57f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.ButtonActive, new ImGuiVector4(0.62f, 0.29f, 0.01f, 1.00f));
            style.SetColor(ColorTarget.Header, new ImGuiVector4(0.59f, 0.28f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.HeaderHovered, new ImGuiVector4(0.74f, 0.35f, 0.02f, 1.00f));
            style.SetColor(ColorTarget.HeaderActive, new ImGuiVector4(0.88f, 0.45f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.Separator, new ImGuiVector4(0.50f, 0.50f, 0.50f, 1.00f));
            style.SetColor(ColorTarget.SeparatorHovered, new ImGuiVector4(0.60f, 0.60f, 0.70f, 1.00f));
            style.SetColor(ColorTarget.SeparatorActive, new ImGuiVector4(0.70f, 0.70f, 0.90f, 1.00f));
            style.SetColor(ColorTarget.ResizeGrip, new ImGuiVector4(1.00f, 1.00f, 1.00f, 0.16f));
            style.SetColor(ColorTarget.ResizeGripHovered, new ImGuiVector4(0.78f, 0.82f, 1.00f, 0.60f));
            style.SetColor(ColorTarget.ResizeGripActive, new ImGuiVector4(0.78f, 0.82f, 1.00f, 0.90f));
            style.SetColor(ColorTarget.CloseButton, new ImGuiVector4(0.50f, 0.50f, 0.90f, 0.50f));
            style.SetColor(ColorTarget.CloseButtonHovered, new ImGuiVector4(0.70f, 0.70f, 0.90f, 0.60f));
            style.SetColor(ColorTarget.CloseButtonActive, new ImGuiVector4(0.70f, 0.70f, 0.70f, 1.00f));
            style.SetColor(ColorTarget.PlotLines, new ImGuiVector4(1.00f, 1.00f, 1.00f, 1.00f));
            style.SetColor(ColorTarget.PlotLinesHovered, new ImGuiVector4(0.90f, 0.70f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.PlotHistogram, new ImGuiVector4(0.90f, 0.70f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.PlotHistogramHovered, new ImGuiVector4(1.00f, 0.60f, 0.00f, 1.00f));
            style.SetColor(ColorTarget.TextSelectedBg, new ImGuiVector4(1.00f, 0.03f, 0.03f, 0.35f));
            style.SetColor(ColorTarget.ModalWindowDarkening, new ImGuiVector4(0.20f, 0.20f, 0.20f, 0.35f));
            style.SetColor(ColorTarget.DragDropTarget, new ImGuiVector4(1.00f, 1.00f, 0.00f, 0.90f));
*/
/*
          var colors = ImGui.GetStyle();
          colors.SetColor(ColorTarget.Text, new ImGuiVector4(0.90f, 0.90f, 0.90f, 1.00f));
          colors.SetColor(ColorTarget.TextDisabled, new ImGuiVector4(0.60f, 0.60f, 0.60f, 1.00f));
          colors.SetColor(ColorTarget.WindowBg, new ImGuiVector4(0.16f, 0.16f, 0.16f, 1.00f));
          colors.SetColor(ColorTarget.ChildBg, new ImGuiVector4(0.12f, 0.12f, 0.12f, 1.00f));
          colors.SetColor(ColorTarget.PopupBg, new ImGuiVector4(0.11f, 0.11f, 0.14f, 0.92f));
          colors.SetColor(ColorTarget.Border, new ImGuiVector4(0.61f, 0.30f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.BorderShadow, new ImGuiVector4(0.00f, 0.00f, 0.00f, 0.00f));
          colors.SetColor(ColorTarget.FrameBg, new ImGuiVector4(0.77f, 0.43f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.FrameBgHovered, new ImGuiVector4(0.98f, 0.61f, 0.26f, 1.00f));
          colors.SetColor(ColorTarget.FrameBgActive, new ImGuiVector4(0.74f, 0.36f, 0.02f, 1.00f));
          colors.SetColor(ColorTarget.TitleBg, new ImGuiVector4(0.40f, 0.19f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.TitleBgActive, new ImGuiVector4(0.75f, 0.37f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.TitleBgCollapsed, new ImGuiVector4(0.74f, 0.36f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.MenuBarBg, new ImGuiVector4(0.29f, 0.29f, 0.30f, 1.00f));
          colors.SetColor(ColorTarget.ScrollbarBg, new ImGuiVector4(0.28f, 0.28f, 0.28f, 1.00f));
          colors.SetColor(ColorTarget.ScrollbarGrab, new ImGuiVector4(0.74f, 0.41f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.ScrollbarGrabHovered, new ImGuiVector4(0.86f, 0.41f, 0.06f, 1.00f));
          colors.SetColor(ColorTarget.ScrollbarGrabActive, new ImGuiVector4(0.64f, 0.29f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.CheckMark, new ImGuiVector4(0.00f, 0.00f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.SliderGrab, new ImGuiVector4(1.00f, 0.80f, 0.54f, 1.00f));
          colors.SetColor(ColorTarget.SliderGrabActive, new ImGuiVector4(0.52f, 0.31f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.Button, new ImGuiVector4(0.73f, 0.37f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.97f, 0.57f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.ButtonActive, new ImGuiVector4(0.62f, 0.29f, 0.01f, 1.00f));
          colors.SetColor(ColorTarget.Header, new ImGuiVector4(0.59f, 0.28f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.HeaderHovered, new ImGuiVector4(0.74f, 0.35f, 0.02f, 1.00f));
          colors.SetColor(ColorTarget.HeaderActive, new ImGuiVector4(0.88f, 0.45f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.Separator, new ImGuiVector4(0.50f, 0.50f, 0.50f, 1.00f));
          colors.SetColor(ColorTarget.SeparatorHovered, new ImGuiVector4(0.60f, 0.60f, 0.70f, 1.00f));
          colors.SetColor(ColorTarget.SeparatorActive, new ImGuiVector4(0.70f, 0.70f, 0.90f, 1.00f));
          colors.SetColor(ColorTarget.ResizeGrip, new ImGuiVector4(1.00f, 1.00f, 1.00f, 0.16f));
          colors.SetColor(ColorTarget.ResizeGripHovered, new ImGuiVector4(0.78f, 0.82f, 1.00f, 0.60f));
          colors.SetColor(ColorTarget.ResizeGripActive, new ImGuiVector4(0.78f, 0.82f, 1.00f, 0.90f));
          colors.SetColor(ColorTarget.CloseButton, new ImGuiVector4(0.50f, 0.50f, 0.90f, 0.50f));
          colors.SetColor(ColorTarget.CloseButtonHovered, new ImGuiVector4(0.70f, 0.70f, 0.90f, 0.60f));
          colors.SetColor(ColorTarget.CloseButtonActive, new ImGuiVector4(0.70f, 0.70f, 0.70f, 1.00f));
          colors.SetColor(ColorTarget.PlotLines, new ImGuiVector4(1.00f, 1.00f, 1.00f, 1.00f));
          colors.SetColor(ColorTarget.PlotLinesHovered, new ImGuiVector4(0.90f, 0.70f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.PlotHistogram, new ImGuiVector4(0.90f, 0.70f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.PlotHistogramHovered, new ImGuiVector4(1.00f, 0.60f, 0.00f, 1.00f));
          colors.SetColor(ColorTarget.TextSelectedBg, new ImGuiVector4(1.00f, 0.03f, 0.03f, 0.35f));
          colors.SetColor(ColorTarget.ModalWindowDarkening, new ImGuiVector4(0.20f, 0.20f, 0.20f, 0.35f));
          colors.SetColor(ColorTarget.DragDropTarget, new ImGuiVector4(1.00f, 1.00f, 0.00f, 0.90f));
          */
