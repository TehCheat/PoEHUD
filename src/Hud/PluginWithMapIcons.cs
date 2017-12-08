using PoeHUD.Controllers;
using PoeHUD.Hud.Interfaces;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using System.Collections.Generic;

namespace PoeHUD.Hud
{
    public abstract class PluginWithMapIcons<TSettings> : Plugin<TSettings>, IPluginWithMapIcons where TSettings : SettingsBase
    {
        protected readonly Dictionary<EntityWrapper, MapIcon> CurrentIcons;

        protected PluginWithMapIcons(GameController gameController, Graphics graphics, TSettings settings) : base(gameController, graphics, settings)
        {
            CurrentIcons = new Dictionary<EntityWrapper, MapIcon>();
            GameController.Area.OnAreaChange += delegate
            {
                CurrentIcons.Clear();
            };
            toRemove = new EntityWrapper[512];
        }

        protected override void OnEntityRemoved(EntityWrapper entityWrapper)
        {
            base.OnEntityRemoved(entityWrapper);
            CurrentIcons.Remove(entityWrapper);
        }

        private EntityWrapper[] toRemove;
        private int index;
        public IEnumerable<MapIcon> GetIcons()
        {
            index = 0;
            foreach (var kv in CurrentIcons)
            {
                if (kv.Value.IsEntityStillValid())
                    yield return kv.Value;
                else
                {
                    toRemove[index] = kv.Key;
                    index++;
                }
            }
            for (int i = 0; i < index; i++)
            {
                CurrentIcons.Remove(toRemove[index]);
            }
        }
    }
}