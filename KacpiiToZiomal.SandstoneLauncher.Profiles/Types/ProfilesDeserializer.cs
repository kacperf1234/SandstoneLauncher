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
            JObject obj = JObject.Parse(json);
            JArray profilesToken = (JArray) obj.SelectToken("profiles");
            JToken idToken = obj.SelectToken("id");
            
            ProfileCollection collection = new ProfileCollection();
            collection.Id = idToken.ToObject<string>();
            collection.Profiles = profilesToken.ToObject<List<Profile>>();

            return collection;
        }
    }
}