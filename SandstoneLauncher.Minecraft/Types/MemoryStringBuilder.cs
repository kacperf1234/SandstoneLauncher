using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class MemoryStringBuilder : IMemoryStringBuilder
    {
        public string Build(int xmx, int xms)
        {
            return $" -Xmx{xmx}M -Xmx{xms}M ";
        }
    }
}