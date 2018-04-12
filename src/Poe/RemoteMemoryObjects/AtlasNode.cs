using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using SharpDX;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class AtlasNode : RemoteMemoryObject
    {
        private WorldArea area;
        public WorldArea Area => area != null ? area :
            area = GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(Address + 0x08));

        private float posX = -1;
        public float PosX => posX != -1 ? posX :
            posX = M.ReadFloat(Address + 0x10);

        private float posY = -1;
        public float PosY => posY != -1 ? posY :
            posY = M.ReadFloat(Address + 0x14);

        public Vector2 Pos => new Vector2(PosX, PosY);

        private string text;
        public string FlavourText => text != null ? text :
            text = M.ReadStringU(M.ReadLong(Address + 0x44));

        public bool IsUniqueMap
        {
            get
            {
                string uniqTest = M.ReadStringU(M.ReadLong(Address + 0x3c, 0));
                return !string.IsNullOrEmpty(uniqTest) && uniqTest.Contains("Uniq");
            }
        }

        public override string ToString()
        {
            return $"{Area.Name}, PosX: {PosX}, PosY: {PosY}, Text: {FlavourText}";
        }
    }
}