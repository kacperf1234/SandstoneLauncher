using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesPropertyGetter
    {
        string GetValue(Natives n, string name);
    }
}