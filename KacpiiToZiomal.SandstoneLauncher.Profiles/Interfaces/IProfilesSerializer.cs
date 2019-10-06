using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces
{
    public interface IProfilesSerializer
    {
        string Serialize(ProfileCollection profiles);
    }
}