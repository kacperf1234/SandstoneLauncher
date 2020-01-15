using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class developertokenexpirationdatetimegenerator_generateexpirationdatetime_tests
    {
        DateTime execute(DateTime now)
        {
            DeveloperTokenExpirationDateTimeGenerator gen = new DeveloperTokenExpirationDateTimeGenerator();
            return gen.GenerateExpirationDateTime(now);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(DateTime.Now));
        }

        [Test]
        public void returns_datetime_is_later_than_now()
        {
            DateTime now = DateTime.Now;
            DateTime results = execute(now);
            
            Assert.IsTrue(DateTime.Compare(now, results) < 0);
        }
    }
}