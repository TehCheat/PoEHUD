using System;
//using SharpDX;
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

namespace PoeHUD.Hud
{
    public class MainMenuWindow
    {
        //To setings ini:
        private bool IsOpened = true;
        private ImGuiVector2 LastSettingPos;
        private ImGuiVector2 LastSettingSize;

        private string CurrentSelected = "";
        private int CurrentSelectedInt = 0;
        private ImGuiVector2 newcontentRegionArea;

        public void Render()
        {
            if (!DrawInfoWindow("PoeHUD", ref IsOpened, 800, 400, 500, 500, WindowFlags.Default, Condition.Appearing))
            {
                ImGuiNative.igGetContentRegionAvail(out newcontentRegionArea);
                if (ImGui.BeginChild("PluginsList", new Vector2(newcontentRegionArea.X * 0.25f, newcontentRegionArea.Y), true, WindowFlags.Default))
                {
                    for (var i = 0; i < PluginExtensionPlugin.Plugins.Count; i++)
                        if (ImGui.Selectable(PluginExtensionPlugin.Plugins[i].PluginName, CurrentSelectedInt == i))
                            CurrentSelectedInt = i;
                }
                ImGui.EndChild();

                ImGui.SameLine();


                ImGui.PushStyleVar(StyleVar.ChildRounding, 5.0f);
                ImGuiNative.igGetContentRegionAvail(out newcontentRegionArea);
                if (ImGui.BeginChild("PluginOptions", new Vector2(newcontentRegionArea.X, newcontentRegionArea.Y), true, WindowFlags.Default))
                {

                }
                ImGui.EndChild();
            }

            LastSettingPos = ImGui.GetWindowPosition();
            LastSettingSize = ImGui.GetWindowSize();
            ImGui.EndWindow();
        }

        public static string ComboBox(string sideLabel, string currentSelectedItem, List<string> objectList, ComboFlags comboFlags = ComboFlags.HeightRegular)
        {
            if (ImGui.BeginCombo(sideLabel, currentSelectedItem, comboFlags))
            {
                var refObject = currentSelectedItem;
                for (var n = 0; n < objectList.Count; n++)
                {
                    var isSelected = refObject == objectList[n];
                    if (ImGui.Selectable(objectList[n], isSelected))
                    {
                        ImGui.EndCombo();
                        return objectList[n];
                    }

                    if (isSelected) ImGui.SetItemDefaultFocus();
                }

                ImGui.EndCombo();
            }

            return currentSelectedItem;
        }

        public bool DrawInfoWindow(string windowLabel, ref bool isOpened, float x, float y, float width, float height, WindowFlags flags, Condition conditions)
        {
            ImGui.SetNextWindowPos(new ImGuiVector2(width + x, height + y), conditions, new ImGuiVector2(1, 1));
            ImGui.SetNextWindowSize(new ImGuiVector2(width, height), conditions);
            return ImGui.BeginWindow(windowLabel, ref isOpened, flags);
        }
    }
}
