#region

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using Newtonsoft.Json;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class launcherprofilesbuilder_build_tests
    {
        private LauncherProfiles execute()
        {
            Assembly a = Assembly.GetExecutingAssembly();
            string[] names = a.GetManifestResourceNames();
            string name = names.Where(x => x.EndsWith(".json")).Where(x => x.Contains("authentication_response"))
                .First();
            Stream stream = a.GetManifestResourceStream(name);
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();

            MojangLoginResponse response = JsonConvert.DeserializeObject<MojangLoginResponse>(json);

            LauncherProfilesBuilder b = new LauncherProfilesBuilder();
            return b.Build(response);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_json()
        {
            Console.WriteLine(JsonConvert.SerializeObject(execute()));
        }
    }
}