using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILibrariesConverter
    {
        string Convert(string[] libs);

        string[] ToStringArray(Library[] libs, OS sys);
    }
}