using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Autofac;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database
{
    public class ContainerDelegate : IContainerDelegate
    {
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder
                .Register(x => new DatabaseContext(StaticConstants.TestConnectionString))
                .As<DbContext>()
                .As<DatabaseContext>();

            IEnumerable<Type> types = GetType().Assembly.GetTypes().Where(t => t.FullName.Contains("Types"))
                .Where(t => t.GetInterfaces().Length > 0)
                .Where(t => t.GetGenericArguments().Length == 0);

            foreach (Type type in types)
                builder.RegisterType(type)
                    .AsSelf()
                    .AsImplementedInterfaces();
        }

        public void RegisterGenerics(ContainerBuilder builder)
        {
        }
    }
}