using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILibraryNativesValidator
    {
        bool Validate(Library lib, OS sys);
    }
}