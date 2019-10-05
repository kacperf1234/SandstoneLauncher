using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces
{
    public interface IProfilesFinder
    {
        Models.Profiles FindExistingProfiles();
    }
}