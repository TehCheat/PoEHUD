using PoeHUD.Controllers;
using PoeHUD.Hud;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoeHUD.DebugPlug
{
    public class DebugPlugin : SizedPlugin<DebugPluginSettings>
    {
        private readonly SettingsHub settingsHub;
        public DebugPlugin(GameController gameController, Graphics graphics, DebugPluginSettings settings, SettingsHub settingsHub)
            : base(gameController, graphics, settings)
        {
            this.settingsHub = settingsHub;
        }

        public override void Render()
        {
            if (DebugDrawInfo.Count == 0 && DebugLog.Count == 0) return;

            Vector2 startPosition = StartDrawPointFunc();
            Vector2 position = startPosition;
            int maxWidth = 0;

            position.Y += 10;
            position.X -= 100;

            foreach (var msg in DebugDrawInfo)
            {
                var size = Graphics.DrawText(msg, 15, position, Color.Green, FontDrawFlags.Right);
                position.Y += size.Height;
                maxWidth = Math.Max(size.Width, maxWidth);
            }
            DebugDrawInfo.Clear();
            foreach (var msg in DebugLog.ToList())
            {
                string displayText = msg.Message;
                if (msg.MessagesCount > 0)
                    displayText = $"({msg.MessagesCount}) {displayText}";

                var size = Graphics.DrawText(displayText, 15, position, msg.Color, FontDrawFlags.Right);

                position.Y += size.Height;
                maxWidth = Math.Max(size.Width, maxWidth);
                if (msg.Exhausted)
                {
                    DebugLog.Remove(msg);
                    MessagesCache.Remove(msg.Message);
                }
            }

            if (maxWidth <= 0) return;
            var bounds = new RectangleF(startPosition.X - maxWidth - 45, startPosition.Y - 5,
                maxWidth + 50, position.Y - startPosition.Y + 10);


            Graphics.DrawImage("preload-start.png", bounds, Color.White);
            Graphics.DrawImage("preload-end.png", bounds, Color.White);
            Size = bounds.Size;
            Margin = new Vector2(0, 5);
        }


        private static List<string> DebugDrawInfo = new List<string>();
        private static List<DisplayMessage> DebugLog = new List<DisplayMessage>();
        private static Dictionary<string, DisplayMessage> MessagesCache = new Dictionary<string, DisplayMessage>();

        private void ClearLog()
        {
            DebugLog.Clear();
            DebugDrawInfo.Clear();
        }

        //If delay is -1 message will newer be destroyed
        public static void LogMsg(object o, float delay)
        {
            if (o == null)
                AddNewMessage("Null", delay, Color.White);
            else
                AddNewMessage(o.ToString(), delay, Color.White);
        }
        public static void LogMsg(object o, float delay, Color color)
        {
            if (o == null)
                AddNewMessage("Null", delay, color);
            else
                AddNewMessage(o.ToString(), delay, color);
        }

        private static void AddNewMessage(string message, float delay, Color color)
        {
            DisplayMessage rezult = null;
            if (MessagesCache.TryGetValue(message, out rezult))
            {
                rezult.MessagesCount++;
                rezult.UpdateTime();
                return;
            }

            rezult = new DisplayMessage(message, delay, color);
            MessagesCache?.Add(message, rezult);
            DebugLog?.Add(rezult);
        }
       
        public class DisplayMessage
        {
            public string Message;
            public Color Color;
            private DateTime OffTime;
            private float Delay;
            public int MessagesCount;

            public DisplayMessage(string message, float delay, Color color)
            {
                Delay = delay;
                Message = message;
                Color = color;

                UpdateTime();
            }
           
            public void UpdateTime()
            {
                if (Delay != -1)
                    OffTime = DateTime.Now.AddSeconds(Delay);
                else
                    OffTime = DateTime.Now.AddDays(2);
            }

            public bool Exhausted
            {
                get
                {
                    return OffTime < DateTime.Now;
                }
            }
        }
    }
}
