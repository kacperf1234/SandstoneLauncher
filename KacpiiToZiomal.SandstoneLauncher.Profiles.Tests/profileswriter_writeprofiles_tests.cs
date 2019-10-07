using System;
using System.Collections.Generic;
using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Tests
{
    public class profileswriter_writeprofiles_tests
    {
        class generator : IProfilesPathGenerator
        {
            public string GeneratePath()
            {
                return "tests\\profileswriter_writeprofiles_tests-profiles.json";
            }
        }
        
        private ProfileCollection _default = new ProfileCollection()
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

        private string _content = "";
        
        void execute(ProfileCollection clt)
        {
            ProfilesWriter w = new ProfilesWriter(new generator(), new FileCreator(new FileNameRemover()), new ProfilesSerializer());
            w.WriteProfiles(clt);
        }

        [SetUp]
        public void setup()
        {
            execute(_default);
            _content = File.ReadAllText(new generator().GeneratePath());
        }

        [TearDown]
        public void teardown()
        {
            generator generator = new generator();
            string path = generator.GeneratePath();
            
            if (File.Exists(path))
                File.Delete(path);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(_default));
        }

        [Test]
        public void content_is_arent_equal_to_empty_string()
        {
            Assert.AreNotEqual("", _content);
        }

        [Test]
        public void deserialize_content_dont_throws_any_exceptions()
        {
            Assert.DoesNotThrow(() => { new ProfilesDeserializer().Deserialize(_content); });
        }

        [Test]
        public void deserialize_content_returns_valid_id()
        {
            ProfileCollection profileCollection = new ProfilesDeserializer().Deserialize(_content);
            string id = profileCollection.Id;
            
            Assert.AreEqual(_default.Id, id);
        }

        [Test]
        public void deserialize_content_returns_valid_profiles_count()
        {
            ProfileCollection collection = new ProfilesDeserializer().Deserialize(_content);
            int count = collection.Profiles.Count;
            
            Assert.IsTrue(count == 1);
        }
    }
}