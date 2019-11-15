using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILibrariesConverter
    {
        string Convert(string[] libs);

        string[] ToStringArray(Library[] libs, OS sys);
    }
}