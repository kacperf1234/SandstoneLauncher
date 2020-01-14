using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;

namespace KacpiiToZiomal.SandstoneLauncher.Commons
{
    public class ContainerDelegate : IContainerDelegate
    {
        public void ConfigureContainer(ContainerBuilder builder)
        {
            IEnumerable<Type> types = GetType().Assembly.GetTypes().Where(t => t.FullName.Contains("Types")).Where(t => t.GetInterfaces().Length > 0)
                .Where(t => t.GetGenericArguments().Length == 0);

            foreach (Type type in types)
            {
                builder.RegisterType(type)
                    .AsSelf()
                    .AsImplementedInterfaces();
            }
        }

        public void RegisterGenerics(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(JsonDeserializer<>))
                .As(typeof(IJsonDeserializer<>));
                    
            builder.RegisterGeneric(typeof(JsonSerializer<>))
                .As(typeof(IJsonSerializer<>));
        }
    }
}