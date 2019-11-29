using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class contentpropertynamegenerator_generatename_tests
    {
        string execute()
        {
            return new ContentPropertyNameGenerator().GenerateName();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => { execute(); });
        }

        [Test]
        public void returns_Content()
        {
            Assert.AreEqual("Content", execute());
        }
    }
}