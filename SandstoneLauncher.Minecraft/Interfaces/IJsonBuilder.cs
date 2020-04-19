namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IJsonBuilder<T>
    {
        string Build(T arg);
    }
}