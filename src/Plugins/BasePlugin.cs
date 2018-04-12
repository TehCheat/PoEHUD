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
using PoeHUD.Hud.Menu.SettingsDrawers;
using System.Diagnostics;
using PoeHUD.Hud;

namespace PoeHUD.Plugins
{
    public class BasePlugin
    {
        internal BasePlugin()
        {
            PluginName = GetType().Name;
        }
        public string PluginDirectory { get; internal set; }
        public string LocalPluginDirectory { get; private set; }
        public string PluginName;

        internal PluginHolder _ExternalPluginData;

        //Diagnostics
        internal Stopwatch DiagnosticTimer;
        internal long AwerageMs;
        internal long TopMs;
        internal long CurrentMs;

        internal void InitPlugin(PluginHolder pluginData)
        {
            _ExternalPluginData = pluginData;
            PluginDirectory = pluginData.PluginDirectory;
            LocalPluginDirectory = PluginDirectory.Substring(PluginDirectory.IndexOf($@"\{PluginExtensionPlugin.PluginsDirectory}\") + 1);
            DiagnosticTimer = new Stopwatch();
        }

        //For modification of default rendering of settings
        public List<BaseSettingsDrawer> SettingsDrawers => _ExternalPluginData.SettingPropertyDrawers;

        //For creating own SettingDrawers
        public int GetUniqDrawerId() => _ExternalPluginData.GetUniqDrawerId();

        public static PluginExtensionPlugin API;
        public GameController GameController => API.GameController;
        public Graphics Graphics => API.Graphics;
        public Memory Memory => GameController.Memory;

        public virtual void Initialise() { }
        public virtual void Render() { }
        public virtual void EntityAdded(EntityWrapper entityWrapper) { }
        public virtual void EntityRemoved(EntityWrapper entityWrapper) { }
        public virtual void OnClose() { }
        public virtual void OnPluginSelectedInMenu() { }

        public virtual bool CanPluginBeEnabledInOptions { get; protected set; } = true;

        #region PluginMethods
        internal virtual bool _allowRender => true;
        private bool _initialized = false;
        private bool DisableDueToError = false;

        internal void _Initialise()
        {
            //If plugin disabled dont init when start
            if (!_allowRender) return;
            if (DisableDueToError) return;

            _ForceInitialize();
        }

        //This will be also called when plugin is disabled, but selected in main menu for settings rendering. We should initialize before generating the menu
        internal void _ForceInitialize()
        {
            if (DisableDueToError) return;
            if (_initialized) return;
            _initialized = true;

            try { Initialise(); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "Initialise"); }
            catch (Exception e) { HandlePluginError("Initialise", e); }

            try { InitializeSettingsMenu(); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "InitializeSettingsMenu"); }
            catch (Exception e) { HandlePluginError("InitializeSettingsMenu", e); }
        }


        internal void _Render()
        {
            if (DisableDueToError) return;
            if (!_allowRender) return;

            if (!_initialized)
            {
                _ForceInitialize();//init if load disabled plugin
                return;
            }

            if (MainMenuWindow.Settings.DeveloperMode.Value)
                DiagnosticTimer.Restart();
            try { Render(); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "Render"); }
            catch (Exception e) { HandlePluginError("Render", e); }

            if (MainMenuWindow.Settings.DeveloperMode.Value)
            {
                DiagnosticTimer.Stop();
                CurrentMs = DiagnosticTimer.ElapsedMilliseconds;
                AwerageMs += (CurrentMs - AwerageMs) / 10;
                TopMs = Math.Max(TopMs, CurrentMs);
            }
        }

        internal void _EntityAdded(EntityWrapper entityWrapper)
        {
            if (DisableDueToError) return;
            if (!_initialized || !_allowRender)
                return;

            try { EntityAdded(entityWrapper); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "EntityAdded"); }
            catch (Exception e) { HandlePluginError("EntityAdded", e); }
        }

        internal void _EntityRemoved(EntityWrapper entityWrapper)
        {
            if (DisableDueToError) return;
            if (!_initialized || !_allowRender) return;

            try { EntityRemoved(entityWrapper); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "EntityRemoved"); }
            catch (Exception e) { HandlePluginError("EntityRemoved", e); }
        }

        internal void _OnClose()
        {
            if (DisableDueToError) return;
            if (!_initialized) return;

            try { OnClose(); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "OnClose"); }
            catch (Exception e) { HandlePluginError("OnClose", e); }

            try { _SaveSettings(); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "SaveSettings"); }
            catch (Exception e) { HandlePluginError("SaveSettings", e); }
        }

        internal virtual void _OnPluginSelectedInMenu()
        {
            if (DisableDueToError) return;
            try { OnPluginSelectedInMenu(); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "OnPluginSelectedInMenu"); }
            catch (Exception e) { HandlePluginError("OnPluginSelectedInMenu", e); }
        }

        internal virtual void _OnPluginDestroyForHotReload()
        {
            if (DisableDueToError) return;
            if (!_initialized) return;

            try { OnPluginDestroyForHotReload(); }
            catch (MissingMemberException me) { ProcessMissingMemberException(me, "OnPluginDestroyForHotReload"); }
            catch (Exception e) { HandlePluginError("OnPluginDestroyForHotReload", e); }
        }

        #endregion

        #region Error Logging
        private void ProcessMissingMemberException(MissingMemberException me, string functionName)
        {
            DisableDueToError = true;
            LogError($"Can't load plugin '{PluginName}' because poehud or plugin is not updated (You can use PluginsUpdater for this). Disabling plugin... ", 20);
            HandlePluginError(functionName, me, false);
        }

        public float PluginErrorDisplayTime = 3;
        private string LogFileName = "ErrorLog.txt";
        private string logPath => PluginDirectory + "\\" + LogFileName;

        internal void HandlePluginError(string methodName, Exception exception, bool showMessage = true)
        {
            if(showMessage)
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

        public virtual void DrawSettingsMenu() { }
        public virtual void InitializeSettingsMenu() { }
        public virtual void OnPluginDestroyForHotReload() { }
        internal virtual SettingsBase _LoadSettings() { return null; }
        internal virtual void _SaveSettings() { }
    }
}
