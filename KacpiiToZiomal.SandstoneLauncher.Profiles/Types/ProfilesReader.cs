using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Types
{
    public class ProfilesReader : IProfilesReader
    {
        public IProfilesPathGenerator ProfilesPathGenerator;
        public IFileReader Reader;
        public IProfilesDeserializer Deserializer;

        public ProfilesReader(IProfilesPathGenerator profilesPathGenerator, IFileReader reader, IProfilesDeserializer deserializer)
        {
            ProfilesPathGenerator = profilesPathGenerator;
            Reader = reader;
            Deserializer = deserializer;
        }

        public ProfileCollection ReadProfiles()
        {
            string path = ProfilesPathGenerator.GeneratePath();
            string content = Reader.Read(path);

            return Deserializer.Deserialize(content);
        }
    }
}