using System.Collections.Generic;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
    public class Assets : Dictionary<string, Asset>
    {
        /// <summary>
        ///     Settings by deserializer to json getted from assets index.
        /// </summary>
        public string BaseJson { get; set; }

        public FullVersion Version { get; set; }

        /// <summary>
        ///     use base.
        ///     it is same
        /// </summary>
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