using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
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