using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILibrariesConverter
    {
        string Convert(string[] libs);

        string[] ToStringArray(Library[] libs, OS sys);
    }
}