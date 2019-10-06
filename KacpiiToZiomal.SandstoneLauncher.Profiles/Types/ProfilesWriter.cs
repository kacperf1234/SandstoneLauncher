using KacpiiToZiomal.SandstoneLauncher.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Types
{
    public class ProfilesWriter : IProfilesWriter
    {
        public IProfilesPathGenerator ProfilesPathGenerator;
        public IFileCreator FileCreator;
        public IProfilesSerializer Serializer;

        public ProfilesWriter(IProfilesPathGenerator profilesPathGenerator, IFileCreator fileCreator, IProfilesSerializer serializer)
        {
            ProfilesPathGenerator = profilesPathGenerator;
            FileCreator = fileCreator;
            Serializer = serializer;
        }

        public void WriteProfiles(ProfileCollection profiles)
        {
            string path = ProfilesPathGenerator.GeneratePath();
            string json = Serializer.Serialize(profiles);
            
            FileCreator.Create(path, json);
        }
    }
}