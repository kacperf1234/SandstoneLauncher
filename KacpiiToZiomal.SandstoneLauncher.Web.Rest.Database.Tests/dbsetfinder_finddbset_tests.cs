using System;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Tests
{
    public class dbsetfinder_finddbset_tests
    {
        DbSet<User> execute()
        {
            DbSet<User> set = new DbSetFinder(new TypeGetter(), new TypeComparer(), new PropertiesFinder(),
                new PropertyInfoIsDbSetValidator(new TypeComparer(), new TypeGetter(), new DbSetTypeProvider(), new GenericArgumentsGetter(),
                    new PropertyInfoContainsGenericArgumentsValidator())).FindDbSet<User>(new DatabaseContext());

            return set;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void tool()
        {
            DbTool tool = new DbTool(new DbSetFinder(new TypeGetter(), new TypeComparer(), new PropertiesFinder(),
                new PropertyInfoIsDbSetValidator(new TypeComparer(), new TypeGetter(), new DbSetTypeProvider(), new GenericArgumentsGetter(),
                    new PropertyInfoContainsGenericArgumentsValidator())), new DatabaseRecordAdder(), new DatabaseRecordRemover(), new DatabaseRecordUpdater());

            User user = tool.Resolve<User>(new DatabaseContext(), x => x.SingleOrDefault(y => y.Email == "kacperf1234@gmail.com"));

            Console.WriteLine(user);
        }
    }
}