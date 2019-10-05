using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class ProfileCollection : List<Profile>
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profiles")]
        public List<Profile> Profiles
        {
            get { return this; }
            set {
                foreach (Profile profile in value)
                {
                    Add(profile);
                }
            }
        }
        
        public void AddProfile(Profile profile)
        {
            Add(profile);
        }

        public void RemoveProfile(Profile profile)
        {
            Remove(profile);
        }

        public void RemoveProfile(Func<List<Profile>, Profile> expression)
        {
            Remove(expression(this));
        }
    }
}