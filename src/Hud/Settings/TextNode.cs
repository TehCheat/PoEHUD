using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeHUD.Hud.Settings
{
    public class TextNode
    {
        [JsonIgnore]
        public Action OnValueChanged = delegate { };
        private string value = "";

        public TextNode()
        {
        }

        public TextNode(string value)
        {
            Value = value;
        }

        public void SetValueNoEvent(string newValue)
        {
            value = newValue;
        }

        public string Value
        {
            get { return value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                 
                    try
                    {
                        OnValueChanged();
                    }
                    catch (Exception)
                    {

                        DebugPlug.DebugPlugin.LogMsg("Error in function that subscribed for: TextNode.OnValueChanged", 10, SharpDX.Color.Red);
                    }
                }
            }
        }

        public static implicit operator string(TextNode node)
        {
            return node.Value;
        }

        public static implicit operator TextNode(string value)
        {
            return new TextNode(value);
        }
    }
}
