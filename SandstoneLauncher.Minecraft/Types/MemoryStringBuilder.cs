using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class MemoryStringBuilder : IMemoryStringBuilder
    {
        public string Build(int xmx, int xms)
        {
            return $" -Xmx{xmx}M -Xmx{xms}M ";
        }
    }
}