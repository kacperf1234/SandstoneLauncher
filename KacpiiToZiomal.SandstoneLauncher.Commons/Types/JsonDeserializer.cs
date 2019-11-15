﻿using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class JsonDeserializer<T> : IJsonDeserializer<T>
    {
        public T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}