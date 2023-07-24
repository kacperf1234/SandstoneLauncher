using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LibraryPathBuilder : ILibraryPathBuilder
    {
        public IPathConverter Converter;
        public IMinecraftDirectory MinecraftDir;

        public LibraryPathBuilder(IMinecraftDirectory minecraftDir, IPathConverter converter)
        {
            MinecraftDir = minecraftDir;
            Converter = converter;
        }

        public string Build(Library lib)
        {
            return MinecraftDir.GetLibraries() + Converter.Convert(lib.Download.Artifact.Path);
        }
    }
}