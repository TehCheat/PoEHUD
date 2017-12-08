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
    public abstract class BasePlugin
    {
        public BasePlugin()
        {
            PluginName = GetType().Name;
        }
        public static PluginExtensionPlugin API;
        public GameController GameController => API.GameController;
        public Graphics Graphics => API.Graphics;
        public Memory Memory => GameController.Memory;


        public string PluginDirectory { get; private set; }
        public string LocalPluginDirectory { get; private set; }
        public string PluginName;

        protected Action eSaveSettings = delegate { };
        protected Action eLoadSettings = delegate { };

        public virtual bool bAllowRender => true;
        private bool _initialized = false;
        #region ExternalInvokeMethods
        public void iInitialise()
        {
            //If plugin disabled dont init when start
            if (!bAllowRender) return;
            try
            {
                Initialise();
                _initialized = true;
            }
            catch (Exception e)
            {
                HandlePluginError("Initialise", e);
            }   
        }
        public void iRender()
        {
            if (!bAllowRender) return;
            //init if load disabled plugin
            if(!_initialized) iInitialise();
            try { Render(); }
            catch (Exception e)
            {
                HandlePluginError("Render", e);
            }
        }
        public void iEntityAdded(EntityWrapper entityWrapper)
        {
            try { EntityAdded(entityWrapper); }
            catch (Exception e)
            {
                HandlePluginError("EntityAdded", e);
            }
        }
        public void iEntityRemoved(EntityWrapper entityWrapper)
        {
            try { EntityRemoved(entityWrapper); }
            catch (Exception e)
            {
                HandlePluginError("EntityRemoved", e);
            }
        }
        public void iOnClose()
        { 
            try { OnClose(); }
            catch (Exception e)
            {
                HandlePluginError("OnClose", e);
            }
            eSaveSettings();
        }
        public void iInitialiseMenu(MenuItem menu)
        {
            try { InitialiseMenu(menu); }
            catch (Exception e)
            {
                HandlePluginError("InitialiseMenu", e);
            }
        }

        public void iLoadSettings()
        {
            try { eLoadSettings(); }
            catch (Exception e)
            {
                HandlePluginError("LoadSettings", e);
            }
        }
        #endregion

        public virtual void Initialise() { }
        public virtual void Render() { }
        public virtual void EntityAdded(EntityWrapper entityWrapper) { }
        public virtual void EntityRemoved(EntityWrapper entityWrapper) { }
        public virtual void OnClose() { }
        public virtual void InitialiseMenu(MenuItem menu) { }

        public float PluginErrorDisplayTime = 3;
        private string LogFileName = "ErrorLog.txt";

        private string logPath => PluginDirectory + "\\" + LogFileName;

        private void HandlePluginError(string methodName, Exception exception)
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
        public static void LogError(object message, float displayTime)
        {
            if(message == null)
                LogError("null", displayTime);
            else
                LogError(message.ToString(), displayTime);
        }
        public static void LogError(string message, float displayTime)
        {
            if(API == null)
                return;

            API.LogError(message, displayTime);
        }

        public static void LogMessage(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime);
            else
                LogMessage(message.ToString(), displayTime);
        }
        public static void LogMessage(string message, float displayTime)
        {
            if (API == null)
                return;

            API.LogMessage(message, displayTime);
        }

        public static void LogMessage(object message, float displayTime, SharpDX.Color color)
        {
            if (message == null)
                DebugPlug.DebugPlugin.LogMsg("null", displayTime, color);
            else
                DebugPlug.DebugPlugin.LogMsg(message.ToString(), displayTime, color);
        }

        public void iInit(PluginExtensionPlugin api, ExternalPlugin pluginData)
        {
            API = api;
            PluginDirectory = pluginData.PluginDir;
            LocalPluginDirectory = PluginDirectory.Substring(PluginDirectory.IndexOf(@"\plugins\") + 1); 
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
