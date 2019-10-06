using System;
using System.Diagnostics;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Tests
{
    public class profilesreader_readprofiles_tests
    {
        ProfileCollection execute()
        {
            ProfilesReader reader = new ProfilesReader(new pathgenerator(), new FileReader(), new ProfilesDeserializer());
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
    }

    class pathgenerator : IProfilesPathGenerator
    {
        public string GeneratePath()
        {
            return "tests-resources\\profiles-temp.json";
        }
    }
}