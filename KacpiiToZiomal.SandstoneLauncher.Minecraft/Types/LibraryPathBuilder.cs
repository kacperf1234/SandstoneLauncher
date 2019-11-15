using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
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