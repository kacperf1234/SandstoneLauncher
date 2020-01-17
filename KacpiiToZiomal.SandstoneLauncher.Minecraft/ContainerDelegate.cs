using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft
{
    public class ContainerDelegate : IContainerDelegate
    {
        public void ConfigureContainer(ContainerBuilder builder)
        {
            IEnumerable<Type> types = GetType().Assembly.GetTypes().Where(t => t.FullName.Contains("Types"))
                .Where(t => t.GetInterfaces().Length > 0);

            foreach (Type type in types)
            {
                if (type.GetGenericArguments().Length < 0)
                {
                    builder.RegisterType(type)
                        .AsSelf()
                        .AsImplementedInterfaces();
                }

                else
                {
                    RegisterGeneric(builder, type);
                }
            }

        }

        void RegisterGeneric(ContainerBuilder builder, Type type)
        {
            Type genericType = type.MakeGenericType();

            builder.RegisterGeneric(genericType)
                .AsSelf()
                .AsImplementedInterfaces();
        }

        public void RegisterGenerics(ContainerBuilder builder)
        {
            throw new System.NotImplementedException();
        }
    }
}