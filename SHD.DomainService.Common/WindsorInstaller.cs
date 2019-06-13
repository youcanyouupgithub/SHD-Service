using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SHD.DomainService.Common
{
    public class WindsorInstaller : BaseWindsorInstaller
    {
        protected override void InstallInternal(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For(typeof(LazyService<>))
                    .ImplementedBy(typeof(LazyService<>))
                    .LifestyleCustom<MsScopedLifestyleManager>()
                );

            container.Register(
                Component
                    .For<LazyService>()
                    .ImplementedBy<LazyService>()
                    .LifestyleCustom<MsScopedLifestyleManager>()
                );
        }
    }
}
