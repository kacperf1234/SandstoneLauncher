using System.Linq;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class PathNameConverter : IPathConverter
    {
        public string Convert(string path)
        {
            return path.Split("/".ToCharArray()[0]).Last();
        }
    }
}