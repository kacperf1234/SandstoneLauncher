using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class PathNameConverter : IPathConverter
    {
        public string Convert(string path)
        {
            return path.Split("/".ToCharArray()[0]).Last();
        }
    }
}