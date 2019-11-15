using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesPropertyGetter
    {
        string GetValue(Natives n, string name);
    }
}