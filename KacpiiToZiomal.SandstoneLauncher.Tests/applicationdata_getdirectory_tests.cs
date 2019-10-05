using System;
using System.Text.RegularExpressions;
using KacpiiToZiomal.SandstoneLauncher.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Tests
{
    public class applicationdata_getdirectory_tests
    {
        string execute()
        {
            ApplicationData data = new ApplicationData();
            return data.GetDirectory();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_string_is_match()
        {
            string excepted = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SandstoneLauncher\\";
            
            Assert.AreEqual(excepted, execute());
        }
    }
}