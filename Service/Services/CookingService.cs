using Models.Application.Items;
using Service.Services.Interfaces;

namespace Service.Services;

public class CookingService : ICookingService
{
    private readonly IOrderItemsPrepires _orderItemsPrepires;

    public CookingService(IOrderItemsPrepires orderItemsPrepires)
    {
        _orderItemsPrepires = orderItemsPrepires;
    }

    public IEnumerable<ReadyDrink?> PrepareDrinks(IEnumerable<Drink> drinks)
    {
        foreach (var drink in drinks) yield return _orderItemsPrepires.Prepare(drink) as ReadyDrink;
    }

    public IEnumerable<ReadyDish?> PrepareDishes(IEnumerable<Dish> dishes)
    {
        foreach (var dish in dishes) yield return _orderItemsPrepires.Prepare(dish) as ReadyDish;
    }
}