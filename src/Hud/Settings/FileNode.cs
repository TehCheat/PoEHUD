using System;
using Newtonsoft.Json;

namespace PoeHUD.Hud.Settings
{
    public sealed class FileNode
    {
        public FileNode()
        {
        }

        public FileNode(string value)
        {
            Value = value;
        }

        [JsonIgnore]
        public Action OnFileChanged = delegate { };

        private string value;

        public string Value
        {
            get { return value; }
            set
            {
                this.value = value;
                OnFileChanged();
            }
        }

        public static implicit operator string(FileNode node)
        {
            return node.Value;
        }

        public static implicit operator FileNode(string value)
        {
            return new FileNode(value);
        }
    }
}