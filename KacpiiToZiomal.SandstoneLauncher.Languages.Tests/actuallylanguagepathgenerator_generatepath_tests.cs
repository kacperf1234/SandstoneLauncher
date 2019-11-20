using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Languages.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Tests
{
    public class actuallylanguagepathgenerator_generatepath_tests
    {
        class appdata : IApplicationData
        {
            public string GetApplicationData()
            {
                return "appdata\\";
            }
        }
        
        string execute()
        {
            ActuallyLanguagePathGenerator generator = new ActuallyLanguagePathGenerator(new appdata());
            return generator.GeneratePath();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => { execute(); });
        }

        [Test]
        public void returns_string_endswith_actuallylanguagejson()
        {
            Assert.IsTrue(execute().EndsWith("actually_language.json"));
        }

        [Test]
        public void returns_string_contains_applicationdata_directory()
        {
            Assert.IsTrue(execute().Contains(new appdata().GetApplicationData()));
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual("appdata\\actually_language.json", execute());
        }
    }
}