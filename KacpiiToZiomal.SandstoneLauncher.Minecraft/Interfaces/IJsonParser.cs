namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IJsonParser<T>
    {
        T Parse(string json);
    }
}