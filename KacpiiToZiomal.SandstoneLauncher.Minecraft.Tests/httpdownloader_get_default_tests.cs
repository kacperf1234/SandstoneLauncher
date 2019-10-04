#region

using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests.Exceptions;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class httpdownloader_get_default_tests
    {
        private readonly string dest = "tests\\samplefile.html";
        private readonly string sampleFile = "http://corpus.canterbury.ac.nz/descriptions/cantrbry/list.html";

        private HttpDownloader execute()
        {
            return HttpDownloader.Default;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void using_default_i_can_normally_download_file()
        {
            execute().Download(sampleFile, "tests\\samplefile.html");
        }

        [Test]
        public void throws_exceptions_by_invoking_event_downloadfile_if_setted()
        {
            HttpDownloader downloader = execute();
            downloader.DownloadFile = (x, y) => throw new TestException();

            Assert.That(() => downloader.Download(sampleFile, dest), Throws.TypeOf<TestException>());
        }

        [TearDown]
        public void teardown()
        {
            if (File.Exists("tests\\samplefile.html"))
                File.Delete("tests\\samplefile.html");
        }
    }
}