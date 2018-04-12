using PoeHUD.Framework;
using PoeHUD.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PoeHUD.Poe.FilesInMemory
{
    public class BaseItemTypes : FileInMemory
    {
        public readonly Dictionary<string, BaseItemType> contents = new Dictionary<string, BaseItemType>();

        public BaseItemTypes(Memory m, long address) : base(m, address)
        {
            LoadItemTypes();
        }

        public BaseItemType Translate(string metadata)
        {
            //if (string.IsNullOrEmpty(metadata))//this shit shows all the time....
            //    throw new Exception("Item metadata is null or empty. Try restart the game to fix this error. \"BaseItemType.Translate(metadata)\"");

            if (!contents.ContainsKey(metadata))
            {
                LoadItemTypes();
            }
            if (!contents.ContainsKey(metadata))
            {
                Console.WriteLine("Key not found in BaseItemTypes: " + metadata);
                return null;
            }
            return contents[metadata];
        }

        private void LoadItemTypes()
        {
            foreach (long i in RecordAddresses())
            {
                string key = M.ReadStringU(M.ReadLong(i));
                var baseItemType = new BaseItemType
                {
                    ClassName = M.ReadStringU(M.ReadLong(i + 0x10, 0)),

                    Width = M.ReadInt(i + 0x18),
                    Height = M.ReadInt(i + 0x1C),
                    BaseName = M.ReadStringU(M.ReadLong(i + 0x20)),
                    DropLevel = M.ReadInt(i + 0x30),
                    Tags = new string[M.ReadLong(i + 0xA8)]
                };
                long ta = M.ReadLong(i + 0xB0);
                for (int k = 0; k < baseItemType.Tags.Length; k++)
                {
                    long ii = ta + 0x8 + 0x10 * k;
                    baseItemType.Tags[k] = M.ReadStringU(M.ReadLong(ii, 0), 255);
                }

                string[] tmpTags = key.Split('/');
                string tmpKey;
                if (tmpTags.Length > 3)
                {
                    baseItemType.MoreTagsFromPath = new string[tmpTags.Length - 3];
                    for (int k = 2; k < tmpTags.Length - 1; k++)
                    {
                        // This Regex and if condition change Item Path Category e.g. TwoHandWeapons
                        // To tag strings type e.g. two_hand_weapon
                        tmpKey = Regex.Replace(tmpTags[k], @"(?<!_)([A-Z])", "_$1").ToLower().Remove(0, 1);
                        if (tmpKey[tmpKey.Length - 1] == 's')
                            tmpKey = tmpKey.Remove(tmpKey.Length - 1);

                        baseItemType.MoreTagsFromPath[k - 2] = tmpKey;
                    }
                }
                else
                {
                    baseItemType.MoreTagsFromPath = new string[1];
                    baseItemType.MoreTagsFromPath[0] = "";
                }

                if (!contents.ContainsKey(key))
                {
                    contents.Add(key, baseItemType);
                }
            }
        }
    }
}