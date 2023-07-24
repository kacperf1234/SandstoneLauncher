namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IHttpBytesReader
    {
        byte[] ReadBytes(string url);
    }
}