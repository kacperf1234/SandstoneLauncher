using System;
using KacpiiToZiomal.SandstoneLauncher.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Tests
{
    public class applicationdata_getbinaries_tests
    {
        string execute()
        {
            ApplicationData data = new ApplicationData();
            return data.GetBinaries();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_string_is_match()
        {
            string excepted = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SandstoneLauncher\\bin\\";
            
            Assert.AreEqual(excepted, execute());
        }
    }
}