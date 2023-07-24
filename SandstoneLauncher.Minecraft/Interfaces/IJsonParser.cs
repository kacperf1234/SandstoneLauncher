namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IJsonParser<T>
    {
        T Parse(string json);
    }
}