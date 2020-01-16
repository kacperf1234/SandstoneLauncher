using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class developertokenarchivedvalidator_validate_tests
    {
        private bool execute(bool archived, DateTime expiration)
        {
            DeveloperTokenActiveValidator v = new DeveloperTokenActiveValidator();

            return v.Validate(new DeveloperToken
            {
                Archived = archived,
                ExpiredAt = expiration
            });
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(false, DateTime.Now));
        }

        [Test]
        public void returns_true_if_archived_is_false_and_expiration_is_later_than_now()
        {
            Assert.IsTrue(execute(false, DateTime.Now.AddMinutes(1)));
        }

        [Test]
        public void returns_false_if_archived_is_false_and_expiration_is_before_than_now()
        {
            DateTime dt = DateTime.Now.AddMinutes(-10D);
            Assert.IsFalse(execute(false, dt));
        }

        [Test]
        public void returns_false_if_archived_is_true()
        {
            Assert.IsFalse(execute(true, DateTime.Now.AddMonths(1)));
            Assert.IsFalse(execute(true, DateTime.Now.AddMonths(-1)));
        }
    }
}