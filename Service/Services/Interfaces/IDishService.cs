using Models.Application;
using Models.Enums;

namespace Service.Services.Interfaces;

public interface IDishService
{
    public List<Dish> GetAll();
    public List<Dish> GetAllAvailable();
    public List<Dish> GetByType(DishType type);
    Task<List<Dish>> GetByIds(List<int> orderDishIds);
}