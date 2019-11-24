using KacpiiToZiomal.SandstoneLauncher.Languages.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Tests
{
    public class languagefilenamevalidator_validate_tests
    {
        private bool execute(string fn)
        {
            LanguageFileNameValidator validator = new LanguageFileNameValidator();
            bool validate = validator.Validate(fn);

            return validate;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("-lang.json"));
        }

        [Test]
        public void returns_excepted_true_result()
        {
            Assert.IsTrue(execute("Pl-lang.json"));
            Assert.IsTrue(execute("En-lang.json"));
            Assert.IsTrue(execute("English-lang.json"));
        }

        [Test]
        public void returns_excepted_false_result()
        {
            Assert.IsFalse(execute("haha.json"));
            Assert.IsFalse(execute("-lang.xml"));
            Assert.IsFalse(execute("---"));
        }
    }
}