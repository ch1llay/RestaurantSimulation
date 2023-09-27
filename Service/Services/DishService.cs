using Models.Application;
using Models.Enums;
using Service.Services.Interfaces;

namespace Service.Services;

public class DishService : IDishService
{
    public List<Dish> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Dish> GetAllAvailable()
    {
        throw new NotImplementedException();
    }

    public List<Dish> GetByType(DishType type)
    {
        throw new NotImplementedException();
    }

    public Task<List<Dish>> GetByIds(List<int> orderDishIds)
    {
        throw new NotImplementedException();
    }
}