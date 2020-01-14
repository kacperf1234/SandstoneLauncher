namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IJsonDeserializer<out T>
    {
        T Deserialize(string json);
    }
}