using Models.Application;
using Models.Enums;
using Service.Services.Interfaces;

namespace Service.Services;

public class DishService : IDishService
{
    public IEnumerable<Dish> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Dish> GetAllAvailable()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Dish> GetByType(DishType type)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetByIds(IEnumerable<int> orderDishIds)
    {
        throw new NotImplementedException();
    }
}