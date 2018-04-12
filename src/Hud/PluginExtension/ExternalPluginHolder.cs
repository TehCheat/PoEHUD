using PoeHUD.Plugins;
using System;
using System.Reflection;
using System.IO;
using PoeHUD.Hud.Menu.SettingsDrawers;
using PoeHUD.Hud.UI;
using PoeHUD.Hud.Settings;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using ImGuiNET;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiVector4 = System.Numerics.Vector4;
using Vector2 = System.Numerics.Vector2;
using PoeHUD.Controllers;

namespace PoeHUD.Hud.PluginExtension
{
    public class ExternalPluginHolder : PluginHolder
    {
        //Saving all references to plugin. Will be destroyed on plugin reload
        internal BasePlugin BPlugin;
        private readonly string FullTypeName;
        private readonly string DllPath;
        //private DateTime DllTimeVersion;
        private FileSystemWatcher DllChangeWatcher;

        public PluginState State { get; private set; }//Will be used by poehud main menu to display why plugin is not loaded/reloaded

        public ExternalPluginHolder(PluginExtensionPlugin api, string dllPath, string fullTypeName) : base(Path.GetFileNameWithoutExtension(dllPath))
        {
            API = api;
            DllPath = dllPath;
            FullTypeName = fullTypeName;
            PluginDirectory = Path.GetDirectoryName(dllPath);

            ReloadPlugin();

            DllChangeWatcher = new FileSystemWatcher();
            DllChangeWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime;// | NotifyFilters.Size | NotifyFilters.FileName;
            DllChangeWatcher.Path = PluginDirectory;
            DllChangeWatcher.Changed += DllChanged;
            DllChangeWatcher.EnableRaisingEvents = true;
        }

        internal override bool CanBeEnabledInOptions { get => BPlugin != null && BPlugin.CanPluginBeEnabledInOptions;  }

        DateTime lastWrite = DateTime.MinValue;
        private void DllChanged(object sender, FileSystemEventArgs e)
        {
            if (!MainMenuWindow.Settings.AutoReloadDllOnChanges.Value) return;
            if (e.FullPath != DllPath) return;//Watchin only dll file

            //Events being raised multiple times https://stackoverflow.com/questions/1764809/filesystemwatcher-changed-event-is-raised-twice
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            if (Math.Abs((lastWriteTime - lastWrite).TotalSeconds) < 1)
            {
                return;
            }
            lastWrite = lastWriteTime;
       

            if (!File.Exists(DllPath))
            {
                State = PluginState.Reload_DllNotFound;
                return;
            }
            BasePlugin.LogMessage("Reloading dll: " + DllPath, 3);
            ReloadPlugin();
        }

        public void ReloadPlugin()
        {
            if (BPlugin != null)
            {
                BPlugin._OnClose();//saving settings, closing opened threads (on plugin side)

                API.eRender -= BPlugin._Render;
                API.eEntityAdded -= BPlugin._EntityAdded;
                API.eEntityRemoved -= BPlugin._EntityRemoved;
                API.eClose -= BPlugin._OnClose;
                API.eInitialise -= BPlugin._Initialise;
                BPlugin._OnPluginDestroyForHotReload();

                BPlugin = null;
                SettingPropertyDrawers.Clear();

                GC.Collect();
            }

            Assembly asmToLoad = null;
            var debugCymboldFilePath = DllPath.Replace(".dll", ".pdb");
            if (File.Exists(debugCymboldFilePath))
            {
                var dbgCymboldBytes = File.ReadAllBytes(debugCymboldFilePath);
                asmToLoad = Assembly.Load(File.ReadAllBytes(DllPath), dbgCymboldBytes);
            }
            else
            {
                asmToLoad = Assembly.Load(File.ReadAllBytes(DllPath));
            }

            if (asmToLoad == null)
            {
                State = PluginState.Reload_DllNotFound;
                return;
            }

            var pluginType = asmToLoad.GetType(FullTypeName);
            if (pluginType == null)
            {
                State = PluginState.Reload_ClassNotFound;
                return;
            }

            //Spawning a new plugin class instance   
            object pluginClassObj = null;
            
            try
            {
                pluginClassObj = Activator.CreateInstance(pluginType);
            }
            catch (Exception ex)
            {
                BasePlugin.LogMessage("Error loading plugin: " + ex.Message, 3);
                State = PluginState.ErrorClassInstance;
                return;
            }

            BPlugin = pluginClassObj as BasePlugin;
            BPlugin.InitPlugin(this);
            Settings = BPlugin._LoadSettings();

            if (!string.IsNullOrEmpty(BPlugin.PluginName))
                PluginName = BPlugin.PluginName;

            API.eRender += BPlugin._Render;
            API.eEntityAdded += BPlugin._EntityAdded;
            API.eEntityRemoved += BPlugin._EntityRemoved;
            API.eClose += BPlugin._OnClose;
            API.eInitialise += BPlugin._Initialise;

            BPlugin._Initialise();

            foreach (var entity in GameController.Instance.EntityListWrapper.Entities.ToList())
            {
                BPlugin._EntityAdded(entity);
            }
        }

        internal override void OnPluginSelectedInMenu()
        {
            if (BPlugin == null) return;
            BPlugin._ForceInitialize();//Added because if plugin is not enabled in options - menu will not be initialized, also possible errors cuz _Initialise was not called
            BPlugin._OnPluginSelectedInMenu();
        }

        internal override void DrawSettingsMenu()
        {
            if (BPlugin == null) return;

            try { BPlugin.DrawSettingsMenu(); }
            catch (Exception e) { BPlugin.HandlePluginError("DrawSettingsMenu", e); }
        }

        public enum PluginState
        {
            Unknown,
            Loaded,
            ErrorClassInstance,
            Reload_CantUnload,
            Reload_DllNotFound,
            Reload_ClassNotFound
        }
    }
}
