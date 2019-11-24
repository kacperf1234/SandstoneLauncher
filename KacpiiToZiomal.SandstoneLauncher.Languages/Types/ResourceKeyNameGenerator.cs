using KacpiiToZiomal.SandstoneLauncher.Languages.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Types
{
    public class ResourceKeyNameGenerator : IResourceKeyNameGenerator
    {
        public static readonly string PREFIX = "ls-";

        public string GenerateName(string keyname)
        {
            return PREFIX + keyname;
        }
    }
}