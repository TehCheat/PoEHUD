using PoeHUD.Plugins;
using System;
using System.Reflection;
using System.IO;

namespace PoeHUD.Hud.PluginExtension
{
    internal sealed class ExternalPlugin
    {
        public string PluginDir; //Will be used for loading resources (images, sounds, etc.) from plugin floder
        private PluginExtensionPlugin API;

        private object PluginInstance;
        public BasePlugin BPlugin;

        private readonly string FullTypeName;
        private readonly string DllPath;

        public PluginState State { get; private set; }//Will be used by poehud main menu to display why plugin is not loaded/reloaded

        public ExternalPlugin(PluginExtensionPlugin api, string dllPath, string fullTypeName)
        {
            API = api;
            DllPath = dllPath;
            FullTypeName = fullTypeName;
            
            PluginDir = Path.GetDirectoryName(dllPath);

            var dllInfo = new FileInfo(DllPath);
            DllTimeVersion = dllInfo.LastWriteTime;

            ReloadPlugin();
            API.eCheckPluginsDllReload += API_eCheckPluginsDllReload;
        }

        private void API_eCheckPluginsDllReload()
        {
            var dllInfo = new FileInfo(DllPath);
            if((dllInfo.LastWriteTime - DllTimeVersion).Seconds > 2)
            {
                DllTimeVersion = dllInfo.LastWriteTime;
                BasePlugin.LogMessage("Reloading dll: " + DllPath, 3);
                ReloadPlugin();
            }
        }

        private DateTime DllTimeVersion;

        public void ReloadPlugin()
        {
            UnloadPlugin();

            var myAsm = Assembly.Load(File.ReadAllBytes(DllPath));
            if (myAsm == null)
            {
                State = PluginState.Reload_DllNotFound;
                return;
            }

            var type = myAsm.GetType(FullTypeName);
            if (type == null)
            {
                State = PluginState.Reload_ClassNotFound;
                return;
            }

            LoadPlugin(type);
        }

        public void LoadPlugin(Type pluginType)
        {
            var pluginInstance = Activator.CreateInstance(pluginType);
            BPlugin = pluginInstance as BasePlugin;

            BPlugin.InitPlugin(this);
            BPlugin._LoadSettings();


            API.eRender += BPlugin._Render;
            API.eEntityAdded += BPlugin._EntityAdded;
            API.eEntityRemoved += BPlugin._EntityRemoved;
            API.eClose += BPlugin._OnClose;
            API.eInitialise += BPlugin._Initialise;
        }

        private void UnloadPlugin()
        {
            if (BPlugin != null)
            {
                BPlugin._OnClose();//saving settings, closing opened threads (on plugin side)

                API.eRender -= BPlugin._Render;
                API.eEntityAdded -= BPlugin._EntityAdded;
                API.eEntityRemoved -= BPlugin._EntityRemoved;
                API.eClose -= BPlugin._OnClose;
                API.eInitialise -= BPlugin._Initialise;
                BPlugin = null;

                GC.Collect();
            }
        }

        public enum PluginState
        {
            Unknown,
            Loaded,
            Reload_CantUnload,
            Reload_DllNotFound,
            Reload_ClassNotFound
        }
    }
}
