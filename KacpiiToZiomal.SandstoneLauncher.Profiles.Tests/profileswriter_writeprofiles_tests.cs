using System;
using System.Collections.Generic;
using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Tests
{
    public class profileswriter_writeprofiles_tests
    {
        private ProfileCollection @default = new ProfileCollection()
        {
            Id = Guid.NewGuid().ToString(),
            Profiles = new List<Profile>()
            {
                new Profile()
                {
                    Account = new OnlineAccount()
                    {
                        Password = "fcbarcelona001",
                        Username = "kacpiitoziomal",
                        Uuid = Guid.NewGuid().ToString(),
                        AccessToken = Guid.NewGuid().ToString(),
                        ClientToken = Guid.NewGuid().ToString(),
                        GameUsername = "kacperf1234"
                    },
                    Metadata = new ProfileMetadata()
                    {
                        CreatedAt = DateTime.Now,
                        EditedAt = DateTime.Now.Add(TimeSpan.FromHours(100))
                    },
                    Resolution = new Resolution()
                    {
                        Height = 480,
                        Width = 854
                    },
                    GameDirectory = ".minecraft\\",
                    GameVersion = new GameVersion()
                    {
                        Id = "1.14.4",
                        Time = DateTime.Now.ToString(),
                        Type = "alpha",
                        Url = "http://",
                        ReleaseTime = DateTime.Now.Add(TimeSpan.FromDays(365)).ToString()
                    },
                    JavaSettings = new JavaSettings()
                    {
                        Arguments = "--x:headumps",
                        Memory = new JavaMemory()
                        {
                            Xms = 256,
                            Xmx = 1024
                        },
                        JavaExecutable = "javaw.exe",
                        MainClass = "net.minecraft.main.Main",
                        RunAs = true
                    },
                    ProfileName = "profilename",
                    ProfileVersion = "1.0"
                }
            }
        };
        
        void execute(ProfileCollection clt)
        {
            ProfilesWriter w = new ProfilesWriter(new pathgenerator(), new FileCreator(new FileNameRemover()), new ProfilesSerializer());
            w.WriteProfiles(clt);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(@default));
        }

        [Test]
        public void file_isnt_be_null()
        {
            execute(@default);
            string text = File.ReadAllText(new pathgenerator().GeneratePath());
            
            Assert.AreNotEqual("", text);
        }
    }
}