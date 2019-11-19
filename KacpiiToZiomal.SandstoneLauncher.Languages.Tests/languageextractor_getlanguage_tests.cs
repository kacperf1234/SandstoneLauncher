using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;
using KacpiiToZiomal.SandstoneLauncher.Languages.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Tests
{
    public class languageextractor_getlanguage_tests
    {
        private Models.Languages Langs = new Models.Languages()
        {
            new Language()
            {
                Data = new LanguageData()
                {
                    LongName = "polish",
                    ShortName = "pl"
                }
            },
            new Language()
            {
                Data = new LanguageData()
                {
                    LongName = "russia",
                    ShortName = "ru"
                }
            },
            new Language()
            {
                Data = new LanguageData()
                {
                    LongName = "english",
                    ShortName = "en"
                }
            }
        };
        
        Language execute(string shortname = "pl", string longname = "polish")
        {
            return new LanguageExtractor().GetLanguage(Langs, new LanguageSettings()
            {
                LongName = longname,
                ShortName = shortname
            });
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => { execute();});
        }

        [Test]
        public void returns_excepted_shortname()
        {
            Assert.AreEqual("pl", execute("pl", "polish").Data.ShortName);
        }

        [Test]
        public void returns_excepted_longname()
        {
            Assert.AreEqual("english", execute("en", "england").Data.LongName);
        }
    }
}