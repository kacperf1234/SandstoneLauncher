using System;
using System.Diagnostics;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Tests
{
    public class profilesreader_readprofiles_tests
    {
        class generator : IProfilesPathGenerator
        {
            public string GeneratePath()
            {
                return "tests\\profilesreader_readprofiles_tests-profiles.json";
            }
        }
        
        ProfileCollection execute()
        {
            ProfilesReader reader = new ProfilesReader(new generator(), new FileReader(), new ProfilesDeserializer());
            return reader.ReadProfiles();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_not_null_profilecollection()
        {
            Assert.NotNull(execute());
        }

        [Test]
        public void returns_profilecollection_contains_valid_id()
        {
            ProfileCollection collection = execute();
            string id = collection.Id;

            Assert.AreEqual("4dba94f8-4a50-4e32-8ca3-4934aa13779c", id);
        }

        [Test]
        public void returns_excepted_items_length()
        {
            int len = execute().Profiles.Count;
            
            Assert.IsTrue(len == 1);
        }

        [Test]
        public void returns_profilecollection_with_not_null_first_item()
        {
            ProfileCollection collection = execute();
            Profile profile = collection.Profiles.First();
            
            Assert.NotNull(profile);
        }
    }

    
}