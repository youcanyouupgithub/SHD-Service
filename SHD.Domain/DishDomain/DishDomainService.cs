using Abp.Domain.Repositories;
using System;
using SHD.DomainEntity;
using System.Threading.Tasks;

namespace SHD.Domain.DishDomain
{
    public class DishDomainService: SHDDomainService
    {
        private readonly IRepository<ShdDish, int> _repositoryShdDish;

        public DishDomainService(IRepository<ShdDish, int> repositoryShdDish)
        {
            _repositoryShdDish = repositoryShdDish;
        }

        /// <summary>
        /// 添加菜品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="picPath"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public async Task<ShdDish> AddShdDish(string name, string picPath, string description)
        {
            var model = ShdDish.Create(name, picPath, description);
            var shdDishId = await _repositoryShdDish.InsertAndGetIdAsync(model);
            var result = await _repositoryShdDish.GetAsync(shdDishId);
            return result;
        }
    }
}
