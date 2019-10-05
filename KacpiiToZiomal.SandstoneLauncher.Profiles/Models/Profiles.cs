using System;
using System.Collections;
using System.Collections.Generic;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class Profiles : List<Profile>
    {
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