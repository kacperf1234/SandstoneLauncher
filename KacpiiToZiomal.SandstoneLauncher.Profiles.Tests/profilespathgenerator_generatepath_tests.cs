using KacpiiToZiomal.SandstoneLauncher.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Types;
using KacpiiToZiomal.SandstoneLauncher.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Tests
{
    public class profilespathgenerator_generatepath_tests
    {
        string execute()
        {
            return new ProfilesPathGenerator(new appdata()).GeneratePath();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual("SandstoneLauncher\\profiles.json", execute());
        }
    }

    class appdata : IApplicationData
    {
        public string GetDirectory()
        {
            return "SandstoneLauncher\\";
        }

        public string GetBinaries()
        {
            throw new System.NotImplementedException();
        }
    }
}