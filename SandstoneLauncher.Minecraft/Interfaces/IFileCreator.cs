namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IFileCreator
    {
        void Create(string path, string cnt);

        void Create(string path, byte[] bytes);
    }
}