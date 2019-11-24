using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class initializemethodnameprovider_providename_tests
    {
        string execute()
        {
            InitializeMethodNameProvider p = new InitializeMethodNameProvider();
            string provideName = p.ProvideName(GetType());

            return provideName;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_name()
        {
            Assert.AreEqual("InitializeComponent", execute());
        }
    }
}