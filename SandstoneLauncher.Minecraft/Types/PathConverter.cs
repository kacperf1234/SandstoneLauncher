using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class PathConverter : IPathConverter
    {
        public string Convert(string path)
        {
            return path.Replace("/", @"\");
        }
    }
}