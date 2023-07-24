using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IRulesValidator
    {
        bool Validate(Rule[] rules, OS sys);
    }
}