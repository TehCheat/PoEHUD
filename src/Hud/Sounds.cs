using System;
using System.Collections.Generic;
using System.IO;
using System.Media;

namespace PoeHUD.Hud
{
    public static class Sounds
    {
        public static SoundPlayer AlertSound;
        public static SoundPlayer DangerSound;
        public static SoundPlayer TreasureSound;
        public static SoundPlayer AttentionSound;
        private static readonly Dictionary<string, SoundPlayer> soundLib = new Dictionary<string, SoundPlayer>();

        public static void AddSound(string name)
        {
            if (!soundLib.ContainsKey(name))
            {
                try
                {
                    String path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), $"sounds/{name}");
                    var soundPlayer = new SoundPlayer(path); 
                    soundPlayer.Load();
                    soundLib[name] = soundPlayer;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error when loading {name}| {ex.Message}:", ex);
                }
            }
        }

        public static SoundPlayer GetSound(string name)
        {
            return soundLib[name];
        }

        public static void LoadSounds()
        {
            AddSound("alert.wav");
            AddSound("danger.wav");
            AddSound("treasure.wav");
            AddSound("attention.wav");
            AlertSound = GetSound("alert.wav");
            DangerSound = GetSound("danger.wav");
            TreasureSound = GetSound("treasure.wav");
            AttentionSound = GetSound("attention.wav");
        }
    }
}