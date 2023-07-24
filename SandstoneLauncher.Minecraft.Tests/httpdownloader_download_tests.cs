#region

using System;
using System.IO;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
public class httpdownloader_download_tests
    {
        private readonly string Ext = ".html";
        private readonly string Url = /*"https://speed.hetzner.de/100MB.bin";*/ "https://miroslawzelent.pl/";
        private string FileName;

        [SetUp]
        public void Setup()
        {
            FileName = "tests\\" + Guid.NewGuid() + Ext;

            IHttpDownloader downloader =
                new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover()));
            downloader.Download(Url, FileName);
        }

        [TearDown]
        public void TearDown()
        {
            File.Delete(FileName);
        }

        [Test]
        public void file_exist()
        {
            Assert.IsTrue(File.Exists(FileName));
        }

        [Test]
        public void returns_content_lenght_more_than_50()
        {
            Assert.IsTrue(File.ReadAllText(FileName).Length > 50);
        }
    }
}