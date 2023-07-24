using System.Collections.Generic;

namespace SandstoneLauncher.Minecraft.Models
{
    [Spencer.NET.SingleInstance]
public class Assets : Dictionary<string, Asset>
    {
        public string BaseJson { get; set; }

        public FullVersion Version { get; set; }

        public Dictionary<string, Asset> AssetList
        {
            set
            {
                Clear();

                foreach (KeyValuePair<string, Asset> item in value) Add(item.Key, item.Value);
            }

            get
            {
                Dictionary<string, Asset> local = new Dictionary<string, Asset>();

                foreach (string key in Keys) local.Add(key, base[key]);

                return local;
            }
        }
    }
}