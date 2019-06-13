using Abp.Dependency;
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SHD.DomainService.Common
{
    public abstract class BaseWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Types
                .FromAssemblyContaining(GetType())
                .IncludeNonPublicTypes()
                .BasedOn<ITransientDependency>()
                .If(x => x.IsGenericTypeDefinition == false)
                .Unless(x => x.IsAbstract)
                .WithServiceSelf()
                .WithServiceDefaultInterfaces()
                .LifestyleCustom<MsScopedLifestyleManager>()
                );

            container.Register(Types
                .FromAssemblyContaining(GetType())
                .IncludeNonPublicTypes()
                .BasedOn<ISingletonDependency>()
                .If(x => x.IsGenericTypeDefinition == false)
                .WithServiceSelf()
                .WithServiceDefaultInterfaces()
                .LifestyleSingleton()
                );

            container.Register(Types
                .FromAssemblyContaining(GetType())
                .IncludeNonPublicTypes()
                .BasedOn<IInterceptor>()
                .If(x => x.IsGenericTypeDefinition == false)
                .WithServiceSelf()
                .WithServiceAllInterfaces()
                .LifestyleCustom<MsScopedLifestyleManager>()
                );

            InstallInternal(container, store);
        }

        protected virtual void InstallInternal(IWindsorContainer container, IConfigurationStore store)
        {

        }
    }
}
