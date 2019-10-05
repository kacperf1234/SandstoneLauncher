using System;
using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Types
{
    public class ProfilesDeserializer : IProfilesDeserializer
    {
        public ProfileCollection Deserialize(string json)
        {
            Console.WriteLine(json);
            
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            JToken profilesToken = obj.SelectToken("profiles");
            JToken idToken = obj.SelectToken("id");
            
            ProfileCollection collection = new ProfileCollection();
            collection.Id = idToken.ToObject<string>();
            collection.Profiles = profilesToken.ToObject<List<Profile>>();

            return collection;
        }
    }
}