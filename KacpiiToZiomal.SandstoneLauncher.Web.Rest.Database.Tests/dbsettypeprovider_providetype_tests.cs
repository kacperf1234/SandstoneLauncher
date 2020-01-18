using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class dbsettypeprovider_providetype_tests
    {
        Type execute() => new DbSetTypeProvider().ProvideType();

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_dbset_type()
        {
            Assert.IsTrue(execute() == typeof(DbSet<>));
        }
    }
}