#region

using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
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