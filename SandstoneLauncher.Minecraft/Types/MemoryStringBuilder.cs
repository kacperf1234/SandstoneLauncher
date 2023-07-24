using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class MemoryStringBuilder : IMemoryStringBuilder
    {
        public string Build(int xmx, int xms)
        {
            return $" -Xmx{xmx}M -Xmx{xms}M ";
        }
    }
}