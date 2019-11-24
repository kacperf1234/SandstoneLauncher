using KacpiiToZiomal.SandstoneLauncher.Languages.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Tests
{
    public class resourcekeynamegenerator_generatename_tests
    {
        private string execute(string k)
        {
            return new ResourceKeyNameGenerator().GenerateName(k);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("xxx"));
        }

        [Test]
        public void returns_string_with_readonly_prefix()
        {
            Assert.IsTrue(execute("x").StartsWith(ResourceKeyNameGenerator.PREFIX));
        }

        [Test]
        public void returns_excepted_string()
        {
            Assert.AreEqual("ls-xxx", execute("xxx"));
        }
    }
}