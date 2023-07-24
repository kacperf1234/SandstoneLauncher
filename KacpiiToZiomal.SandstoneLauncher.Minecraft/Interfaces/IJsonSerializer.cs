namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IJsonSerializer<T>
    {
        string Serialize(T arg);
    }
}