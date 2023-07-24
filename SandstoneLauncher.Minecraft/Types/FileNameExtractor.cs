using System.Linq;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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