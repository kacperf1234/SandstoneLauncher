namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IJsonDeserializer<T>
    {
        T Deserialize(string json);
    }
}