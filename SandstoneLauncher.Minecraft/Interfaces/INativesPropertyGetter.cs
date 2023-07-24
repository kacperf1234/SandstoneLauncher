using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesPropertyGetter
    {
        string GetValue(Natives n, string name);
    }
}