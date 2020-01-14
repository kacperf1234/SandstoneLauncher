using System;
using System.Linq;
using System.Reflection;
using Autofac;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Types
{
    public class ContainerConfigurator
    {
        public IContainerDelegateTypeFinder DelegateTypeFinder;
        public IContainerDelegateTypeValidator DelegateTypeValidator;
        public IReferencedAssemblyNamesGetter ReferencedAssemblyNamesGetter;
        public IAssemblyLoader AssemblyLoader;
        
        public ContainerConfigurator(IAssemblyLoader assemblyLoader, IReferencedAssemblyNamesGetter referencedAssemblyNamesGetter, IContainerDelegateTypeValidator delegateTypeValidator, IContainerDelegateTypeFinder delegateTypeFinder)
        {
            AssemblyLoader = assemblyLoader;
            ReferencedAssemblyNamesGetter = referencedAssemblyNamesGetter;
            DelegateTypeValidator = delegateTypeValidator;
            DelegateTypeFinder = delegateTypeFinder;
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            ConfigureContainerFor(builder);
        }

        public void ConfigureContainerFor(ContainerBuilder builder, Assembly targetAssembly = null)
        {
            targetAssembly ??= Assembly.GetExecutingAssembly();
            AssemblyName[] names = ReferencedAssemblyNamesGetter.GetReferencedAssemblyNames(targetAssembly)
                .Where(ass => ass.FullName.StartsWith("KacpiiToZiomal.SandstoneLauncher"))
                .Where(ass => !ass.FullName.EndsWith("Tests"))
                .ToArray();
            
            foreach (AssemblyName name in names)
            {
                Assembly assembly = AssemblyLoader.Load(name);
                Type containerDelegateType = DelegateTypeFinder.Find(assembly);

                if (DelegateTypeValidator.Validate(containerDelegateType))
                {
                    IContainerDelegate containerDelegate = (IContainerDelegate) Activator.CreateInstance(containerDelegateType);
                    containerDelegate.RegisterGenerics(builder);
                    containerDelegate.ConfigureContainer(builder);
                }
            }
        }

        public static ContainerConfigurator Create()
        {
            return 
                new ContainerConfigurator(new AssemblyLoader(), new ReferencedAssemblyNamesGetter(),
                new ContainerDelegateTypeValidator(new ContainerDelegateInterfaceNameProvider()),
                new ContainerDelegateTypeFinder(new ContainerDelegateTypeValidator(new ContainerDelegateInterfaceNameProvider())));
        }
    }
}