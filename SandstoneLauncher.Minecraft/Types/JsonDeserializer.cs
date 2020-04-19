using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class JsonDeserializer<T> : IJsonDeserializer<T>
    {
        public T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}