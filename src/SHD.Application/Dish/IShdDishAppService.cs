using Abp.Application.Services;
using SHD.Dish.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SHD.Dish
{
    public interface IShdDishAppService : IApplicationService
    {
        Task AddShdDish(AddShdDishInput input);
    }
}
