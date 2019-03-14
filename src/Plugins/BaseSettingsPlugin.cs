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
    public class BaseSettingsPlugin<TSettings> : BasePlugin where TSettings : SettingsBase, new()
    {
        internal override bool _allowRender => Settings.Enable.Value;

        #region Settings
        public TSettings Settings { get; private set; }
        private string SettingsFileName = "config.ini";

        private string SettingsFullPath => PluginDirectory + "\\" + SettingsFileName;

        internal override SettingsBase _LoadSettings()
        {
            try
            {
                var settingsFullPath = SettingsFullPath;

                if (File.Exists(settingsFullPath))
                {
                    string json = File.ReadAllText(settingsFullPath);
                    if (!string.IsNullOrEmpty(json))
	                {
		                Settings = JsonConvert.DeserializeObject<TSettings>(json, SettingsHub.jsonSettings);
	                }
	                else
	                {
		                LogError($"Plugin: {PluginName}: Settings file is empty (bug?), generating new config...", 4);
	                }
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
            return Settings;
        }

        internal override void _SaveSettings()
        {
            try
            {
                if (Settings == null) return;
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

        //if you going to draw menu fully on ur side- override this and do ur stuff there
        public override void DrawSettingsMenu()
        {
            _ExternalPluginData.DrawGeneratedSettingsMenu();
        }

        //I still need this to add own settings drawers to menu
        //if you going to draw menu fully on ur side- override this and clear the base call code
        public override void InitializeSettingsMenu()
        {
            _ExternalPluginData.InitializeSettingsMenu();
        }
    }
}