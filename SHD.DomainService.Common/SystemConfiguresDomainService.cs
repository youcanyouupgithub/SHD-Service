using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SHD.DomainService.Common
{
    /// <summary>
    /// 部署领域服务
    /// </summary>
    public class SystemConfiguresDomainService : Abp.Domain.Services.DomainService
    {
       
        private readonly IRepository<SystemConfigures, int> _repositorySystemConfigures;
       
        public SystemConfiguresDomainService(IRepository<SystemConfigures, int> repositorySystemConfigures)
        {
            _repositorySystemConfigures = repositorySystemConfigures;
        }

        public async Task<List<string>> GetPlatformServiceKeys()
        {
            var query = from config in _repositorySystemConfigures.GetAll()
                        where string.Equals(SystemConfigures.PlatformServiceKey, config.Key, StringComparison.InvariantCultureIgnoreCase)
                        select config.Value;
            return await query.ToListAsync();
        }

        public async Task<List<string>> GetCommonServiceKeys()
        {
            var query = from config in _repositorySystemConfigures.GetAll()
                        where string.Equals(SystemConfigures.CommonServiceKey, config.Key, StringComparison.InvariantCultureIgnoreCase)
                        select config.Value;
            return await query.ToListAsync();
        }
    }
}