using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class ProfileCollection
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profiles")]
        public List<Profile> Profiles
        {
//            get { return this; }
//            set {
//                foreach (Profile profile in value)
//                {
//                    Add(profile);
//                }
//            }

            get;
            set;
        }

        public ProfileCollection()
        {
            Profiles = new List<Profile>();
        }
        
        public void AddProfile(Profile profile)
        {
            Profiles.Add(profile);
        }

        public void RemoveProfile(Profile profile)
        {
            Profiles.Remove(profile);
        }

        public void RemoveProfile(Func<List<Profile>, Profile> expression)
        {
            Profiles.Remove(expression(Profiles));
        }
    }
}