using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace SHD.DomainService.Common
{
    public sealed class LazyService<T>
    {
        public LazyService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private readonly IServiceProvider _serviceProvider;

        public T Instance
        {
            get
            {
                return _serviceProvider.GetService<T>();
            }
        }
    }

    public sealed class LazyService
    {
        public LazyService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private readonly IServiceProvider _serviceProvider;

        public T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }

        public IEnumerable<T> GetServices<T>()
        {
            return _serviceProvider.GetServices<T>();
        }
    }
}
