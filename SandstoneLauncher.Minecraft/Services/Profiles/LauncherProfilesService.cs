using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Services.Profiles
{
    [SingleInstance]
    public class LauncherProfilesService
    {
        // TODO: These defaults are bad way.
        private const string LauncherName = "SandstoneLauncher";
        private const int Format = 21;
        private const int ProfilesFormat = 1;
        private const string DefaultClientToken = "abc";
        private const string DefaultSelectedProfile = "";
        private const string DefaultSelectedUser = "";

        private IMinecraftDirectory MinecraftDirectory;

        public LauncherProfilesService()
        {
            MinecraftDirectory = new MinecraftDirectory();
        }

        [Inject]
        public IJsonDeserializer<LauncherProfiles> Deserializer { get; set; }
        
        [Inject]
        public IJsonSerializer<LauncherProfiles> Serializer { get; set; }
        
        [Inject]
        public IJsonDeserializer<LauncherProfile> ProfileDeserializer { get; set; }
        
        [Inject]
        public IJsonSerializer<LauncherProfile> ProfileSerializer { get; set; }

        private void SaveLauncherProfiles(LauncherProfiles profiles)
        {
            string json = JsonConvert.SerializeObject(profiles);
            File.WriteAllText(MinecraftDirectory.GetLauncherProfiles(), json);
        }

        private LauncherProfiles Deserialize(string json)
        {
            return Deserializer.Deserialize(json);
        }

        private string Serialize(LauncherProfiles profiles)
        {
            return Serializer.Serialize(profiles);
        }

        private LauncherProfiles ReadProfiles()
        {
            var file = MinecraftDirectory.GetLauncherProfiles();
            var json = File.ReadAllText(file);
            return Deserialize(json);
        }

        private LauncherProfiles ReadProfilesOrCreateEmpty()
        {
            string file = MinecraftDirectory.GetLauncherProfiles();
            return File.Exists(file) ? ReadProfiles() : CreateEmpty();
        }

        private LauncherProfiles CreateEmpty()
        {
            LauncherProfiles empty = GenerateEmpty();
            var json = Serialize(empty);
            File.WriteAllText(MinecraftDirectory.GetLauncherProfiles(), json);
            return empty;
        }

        private LauncherProfiles GenerateEmpty()
        {
            return new LauncherProfiles
            {
                AuthenticationDatabase = new Dictionary<string, AuthenticationDatabase>(),
                LauncherVersion = new LauncherVersion { Name = LauncherName, Format = Format, ProfilesFormat = ProfilesFormat },
                Profiles = new Dictionary<string, LauncherProfile>(),
                ClientToken = DefaultClientToken,
                SelectedProfile = DefaultSelectedProfile,
                SelectedUser = DefaultSelectedUser
            };
        }

        public IEnumerable<LauncherProfile> GetLauncherProfiles()
        {
            return ReadProfilesOrCreateEmpty().Profiles.Values;
        }

        public void PutProfile(LauncherProfile profile)
        {
            var launcherProfiles = ReadProfilesOrCreateEmpty();
            launcherProfiles.Profiles.Add(profile.Name, profile);
            SaveLauncherProfiles(launcherProfiles);
        }

        public bool DeleteProfile(string profileName)
        {
            var launcherProfiles = ReadProfilesOrCreateEmpty();
            var r = launcherProfiles.Profiles.Remove(profileName);
            SaveLauncherProfiles(launcherProfiles);
            return r;
        }

        public void UpdateProfile(LauncherProfile profile)
        {
            var launcherProfiles = ReadProfilesOrCreateEmpty();
            launcherProfiles.Profiles[profile.Name] = profile;
            SaveLauncherProfiles(launcherProfiles);
        }
    }
}