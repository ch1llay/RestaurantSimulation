using Models.Application;
using Models.Enums;

namespace Service.Services.Interfaces;

public interface IDishService
{
    public IEnumerable<Dish> GetAll();
    public IEnumerable<Dish> GetAllAvailable();
    public IEnumerable<Dish> GetByType(DishType type);
    Task<IEnumerable<Dish>> GetByIds(IEnumerable<int> orderDishIds);
}