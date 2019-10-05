using KacpiiToZiomal.SandstoneLauncher.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Types
{
    public class ProfilesPathGenerator : IProfilesPathGenerator
    {
        public IApplicationData AppData;

        public ProfilesPathGenerator(IApplicationData appData)
        {
            AppData = appData;
        }

        public string GeneratePath()
        {
            return AppData.GetDirectory() + "profiles.json";
        }
    }
}