using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class developertokenvalidator_validate_tests
    {
        bool execute(DeveloperToken t) => new DeveloperTokenValidator().Validate(t);

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(null));
        }

        [Test]
        public void returns_true_when_object_isnt_null()
        {
            Assert.IsTrue(execute(new DeveloperToken()));
        }

        [Test]
        public void returns_true_when_object_is_null()
        {
            Assert.IsFalse(execute(null));
        }
    }
}