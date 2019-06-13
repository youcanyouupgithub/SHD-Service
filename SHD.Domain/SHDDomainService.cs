using Abp;
using Abp.Dependency;
using Abp.Domain.Services;
using SHD.DomainService.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SHD.Domain
{
    public abstract class SHDDomainService : Abp.Domain.Services.DomainService
    {
        public LazyService ServiceProxy { get; set; }
    }
}
