using Models.Application;
using Models.Enums;
using Service.Performers;
using Service.Performers.Interfaces;

namespace Service.Factories;

public class CookFactory
{
    public static ICook GetCook(Dish dish)
    {
        return dish.DishType switch
        {
            DishType.Cold => new ColdCook(),
            DishType.Hot => new HotCook(),
            DishType.Confectionery => new ConfectioneryCook(),
            _ => throw new ArgumentOutOfRangeException(nameof(dish.DishType))
        };
    }
}