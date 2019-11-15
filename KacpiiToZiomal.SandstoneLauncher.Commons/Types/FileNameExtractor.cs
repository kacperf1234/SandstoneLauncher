using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class FileNameExtractor : IFileNameExtractor
    {
        public IPathConverter Converter;

        public FileNameExtractor(IPathConverter converter)
        {
            Converter = converter;
        }

        public string GetName(string path)
        {
            string[] segments = Converter.Convert(path).Split("\\".ToCharArray()[0]);
            return segments.Last();
        }
    }
}