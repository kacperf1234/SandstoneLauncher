using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces
{
    public interface IProfilesWriter
    {
        void WriteProfiles(ProfileCollection profiles);
    }
}