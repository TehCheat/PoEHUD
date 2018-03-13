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

namespace PoeHUD.Plugins
{
    public class BasePlugin
    {
        internal BasePlugin()
        {
            PluginName = GetType().Name;
        }
        public string PluginDirectory { get; private set; }
        public string LocalPluginDirectory { get; private set; }
        public string PluginName;

        internal void InitPlugin(ExternalPlugin pluginData)
        {
            PluginDirectory = pluginData.PluginDir;
            LocalPluginDirectory = PluginDirectory.Substring(PluginDirectory.IndexOf($@"\{PluginExtensionPlugin.PluginsDirectory}\") + 1);
        }

        public static PluginExtensionPlugin API;
        public GameController GameController => API.GameController;
        public Graphics Graphics => API.Graphics;
        public Memory Memory => GameController.Memory;

        public virtual void Initialise() { }
        public virtual void Render() { }
        public virtual void EntityAdded(EntityWrapper entityWrapper) { }
        public virtual void EntityRemoved(EntityWrapper entityWrapper) { }
        public virtual void OnClose() { }


        #region PluginMethods
        internal virtual bool _allowRender => true;
        private bool _initialized = false;

        internal void _Initialise()
        {
            if (_initialized) return;

            //If plugin disabled dont init when start
            if (!_allowRender) return;

            try { Initialise(); }
            catch (Exception e) { HandlePluginError("Initialise", e); }

            _initialized = true;
        }

        internal void _Render()
        {
            if (!_initialized) _Initialise();//init if load disabled plugin

            if (!_allowRender) return;

            try { Render(); }
            catch (Exception e) { HandlePluginError("Render", e); }
        }

        internal void _EntityAdded(EntityWrapper entityWrapper)
        {
            if (!_initialized || !_allowRender)
                return;

            try { EntityAdded(entityWrapper); }
            catch (Exception e) { HandlePluginError("EntityAdded", e); }
        }

        internal void _EntityRemoved(EntityWrapper entityWrapper)
        {
            if (!_initialized || !_allowRender) return;

            try { EntityRemoved(entityWrapper); }
            catch (Exception e) { HandlePluginError("EntityRemoved", e); }
        }

        internal void _OnClose()
        {
            if (!_initialized) return;

            try { OnClose(); }
            catch (Exception e) { HandlePluginError("OnClose", e); }

            try { SaveSettings(); }
            catch (Exception e) { HandlePluginError("SaveSettings", e); }
        }

        #endregion

<<<<<<< HEAD
        public virtual void Initialise() { }
        public virtual void Render() { }
        public virtual void RenderMenu() { }
        public virtual void EntityAdded(EntityWrapper entityWrapper) { }
        public virtual void EntityRemoved(EntityWrapper entityWrapper) { }
        public virtual void OnClose() { }
=======
        internal virtual void _LoadSettings() { }
        internal virtual void SaveSettings() { }
>>>>>>> a69f31c5cb975407a3afee9dfedc990145a7cf51

        #region Error Logging
        public float PluginErrorDisplayTime = 2;
        private string LogFileName = "ErrorLog.txt";
        private string logPath => PluginDirectory + "\\" + LogFileName;

        internal void HandlePluginError(string methodName, Exception exception)
        {
            LogError($"Plugin: '{PluginName}', Error in function: '{methodName}' : '{exception.Message}'", PluginErrorDisplayTime);

            try
            {
                using (StreamWriter w = File.AppendText(logPath))
                {
                    w.Write("\r\nLog Entry : ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                    w.WriteLine($" Method error: {methodName} : {exception.ToString()}");
                    w.WriteLine("-------------------------------");
                }
            }
            catch (Exception e)
            {
                LogError(" Can't save error log. Error: " + e.Message, 5);
            }
        }
        #endregion

        #region Logging


        public static void LogError(string message, float displayTime) => LogError((object)message, displayTime);
        public static void LogMessage(string message, float displayTime) => LogMessage((object)message, displayTime);


        public static void LogError(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.Red);
            else
                LogMessage(message.ToString(), displayTime, Color.Red);
        }

        public static void LogMessage(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.White);
            else
                LogMessage(message.ToString(), displayTime, Color.White);
        }

        public static void LogWarning(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.Yellow);
            else
                LogMessage(message.ToString(), displayTime, Color.Yellow);
        }

        public static void LogMessage(object message, float displayTime, Color color)
        {
            if (message == null)
                DebugPlug.DebugPlugin.LogMsg("null", displayTime, color);
            else
                DebugPlug.DebugPlugin.LogMsg(message.ToString(), displayTime, color);
        }
        #endregion
    }
}
