using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SHD.Dish.Dto;
using SHD.Domain.DishDomain;
using SHD.DomainService.Common;

namespace SHD.Dish
{
    public class ShdDishAppService : SHDAppServiceBase, IShdDishAppService
    {
        public LazyService ServiceProxy { get; set; }

        public async Task AddShdDish(AddShdDishInput input)
        {
            //var shdDishDomainService = await ServiceProxy.GetService<DishDomainService>();

            throw new NotImplementedException();
        }
    }
}
