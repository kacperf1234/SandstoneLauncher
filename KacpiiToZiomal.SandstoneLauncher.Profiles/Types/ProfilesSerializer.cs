using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Types
{
    public class ProfilesSerializer : IProfilesSerializer
    {
        public string Serialize(ProfileCollection profiles)
        {
            return JsonConvert.SerializeObject(profiles);
        }
    }
}