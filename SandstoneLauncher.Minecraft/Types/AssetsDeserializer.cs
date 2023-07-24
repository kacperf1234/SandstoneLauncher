using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class AssetsDeserializer : IJsonDeserializer<Assets>
    {
        public Assets Deserialize(string json)
        {
            Assets assets = new Assets();

            object o = JsonConvert.DeserializeObject(json);
            JObject obj = JObject.FromObject(o);

            JToken token = obj.SelectToken("objects");
            assets.AssetList = token.ToObject<Dictionary<string, Asset>>();

            return assets;
        }
    }
}