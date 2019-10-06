using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Tests
{
    public class profilesdeserializer_deserialize_tests
    {
        ProfileCollection execute()
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            string name = ass.GetManifestResourceNames().Where(x => x.Contains("profiles.json")).First();
            string json = new StreamReader(ass.GetManifestResourceStream(name)).ReadToEnd();
            
            ProfilesDeserializer d = new ProfilesDeserializer();
            return d.Deserialize(json);
        }

        [Test]  
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_items_count()
        {
            Assert.IsTrue(execute().Profiles.Count == 2);
        }

        [Test]
        public void returns_excepted_first_item()
        {
            Assert.AreEqual("sample-profile1", execute().Profiles[0].ProfileName);
        }
    }
}