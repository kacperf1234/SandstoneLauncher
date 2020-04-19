#region

using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class versiongetter_get_tests
    {
        private IEnumerable<GameVersion> execute(VersionType type = VersionType.ALPHA)
        {
            VersionManifest manifest = new ManifestJsonDeserializer().Deserialize(new HttpClient()
                .GetStringAsync("https://launchermeta.mojang.com/mc/game/version_manifest.json").Result);

            VersionsFilter getter = new VersionsFilter(new VersionTypeGetter());
            return getter.FilterVersions(manifest, type);
        }

        [Test]
        public void returns_alpha_versions_more_than_zero()
        {
            Assert.IsTrue(execute().Count() > 0);
        }

        [Test]
        public void returns_beta_versions_more_than_zero()
        {
            Assert.IsTrue(execute().Count() > 0);
        }
    }
}