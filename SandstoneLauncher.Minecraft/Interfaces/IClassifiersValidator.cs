using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IClassifiersValidator
    {
        bool Validate(Classifiers c, OS sys);
    }
}