using System.Collections.Generic;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Languages.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Tests
{
    public class languagefilesfilter_filter_tests
    {
        IEnumerable<string> execute(params string[] arr)
        {
            LanguageFilesFilter filter = new LanguageFilesFilter(new LanguageFileNameValidator());
            return filter.Filter(arr);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("", ""));
        }

        [Test]
        public void returns_excepted_items_length()
        {
            Assert.IsTrue(execute("pl-lang.json", "enlang.json", "hello.json", "ru-lang.json").Count() == 2);
        }

        [Test]
        public void returns_excepted_items_using_linq()
        {
            Assert.DoesNotThrow(() => execute("pl-lang.json", "enlang.json").Where(x => x == "pl-lang.json").First());
        }
    }
}