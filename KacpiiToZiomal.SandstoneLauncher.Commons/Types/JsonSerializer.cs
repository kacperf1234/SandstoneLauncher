using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class JsonSerializer<T> : IJsonSerializer<T>
    {
        public string Serialize(T arg)
        {
            return JsonConvert.SerializeObject(arg, Formatting.Indented);
        }
    }
}