#region

using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class nativesdownloader_download_tests
    {
        private void execute()
        {
            IFullVersionFinder finder = new FullVersionFinder(new NetworkClient(), new FullVersionParser());
            FullVersion version = finder.Find("https://launchermeta.mojang.com/v1/packages/7f40b382dedcfe9eca74a5b14d615075ec34c108/1.9.4.json");

            NativesDownloader d = new NativesDownloader(
                new NativesPathFinder(new MinecraftDirectory(), new PathConverter()),
                new LibraryNativesValidator(
                    new NativesValidator(new OperatingSystemConverter(), new NativesPropertyGetter()),
                    new ClassifiersValidator()), new ArtifactFinder(),
                new HttpDownloader(new DirectoryCreator(new FileNameRemover())),
                new NativesTemporaryPathFinder(new FileNameExtractor(new PathConverter()), new MinecraftDirectory()),
                new JarFileExtractor(), new NativesDirectory(new MinecraftDirectory(), DirectoryCreator.Default));
            d.Download(version.Libraries, OS.WINDOWS, version);
        }

        [Test]
        public void does_not_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }
    }
}