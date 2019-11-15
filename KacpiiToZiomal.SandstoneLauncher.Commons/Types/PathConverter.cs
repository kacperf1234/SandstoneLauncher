using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class PathConverter : IPathConverter
    {
        public string Convert(string path)
        {
            return path.Replace("/", @"\");
        }
    }
}