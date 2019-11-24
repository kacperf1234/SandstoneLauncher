using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class PathNameConverter : IPathConverter
    {
        public string Convert(string path)
        {
            return path.Split("/".ToCharArray()[0]).Last();
        }
    }
}