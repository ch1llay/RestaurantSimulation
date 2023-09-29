using Service.Items;
using Service.Models;
using Service.Services.Interfaces;

namespace Service.Services;

public class CookingService : ICookingService
{
    private readonly IMenuItemsPrepires _menuItemsPrepires;

    public CookingService(IMenuItemsPrepires menuItemsPrepires)
    {
        _menuItemsPrepires = menuItemsPrepires;
    }

    public IEnumerable<ReadyDrink?> PrepareDrinks(IEnumerable<Drink> drinks)
    {
        foreach (var drink in drinks) yield return _menuItemsPrepires.Prepare(drink) as ReadyDrink;
    }

    public IEnumerable<ReadyDish?> PrepareDishes(IEnumerable<Dish> dishes)
    {
        foreach (var dish in dishes) yield return _menuItemsPrepires.Prepare(dish) as ReadyDish;
    }
}