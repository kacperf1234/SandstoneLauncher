using System.Linq;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class PathNameConverter : IPathConverter
    {
        public string Convert(string path)
        {
            return path.Split("/".ToCharArray()[0]).Last();
        }
    }
}