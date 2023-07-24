using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class PathConverter : IPathConverter
    {
        public string Convert(string path)
        {
            return path.Replace("/", @"\");
        }
    }
}