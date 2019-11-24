using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Tests
{
    public class httpbytesreader_readbytes_tests
    {
        private byte[] execute(string url)
        {
            HttpBytesReader r = new HttpBytesReader();
            byte[] readBytes = r.ReadBytes(url);

            return readBytes;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => { execute("http://www.google.com"); });
        }

        [Test]
        public void returns_lenght_more_than_1()
        {
            Assert.IsTrue(execute("http://www.google.com").Length > 1);
        }
    }
}