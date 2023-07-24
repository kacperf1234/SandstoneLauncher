using SandstoneLauncher.Minecraft.Enums;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IFileTypeGetter
    {
        FileType GetFileType(string arg);
    }
}