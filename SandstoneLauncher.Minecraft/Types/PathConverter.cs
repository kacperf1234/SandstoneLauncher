using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class PathConverter : IPathConverter
    {
        public string Convert(string path)
        {
            return path.Replace("/", @"\");
        }
    }
}