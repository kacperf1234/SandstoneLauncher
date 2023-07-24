using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILibraryValidator
    {
        bool Validate(Library lib, OS sys);
    }
}