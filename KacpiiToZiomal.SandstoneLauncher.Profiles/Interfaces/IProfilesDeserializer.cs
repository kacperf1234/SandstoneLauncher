namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces
{
    public interface IProfilesDeserializer
    {
        Models.ProfileCollection Deserialize(string json);
    }
}