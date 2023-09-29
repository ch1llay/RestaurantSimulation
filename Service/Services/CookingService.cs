using Domain.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Service.DI.Interfaces;
using Service.Items;
using Service.Models;
using Service.Services.Interfaces;

namespace Service.Services;

public class CookingService : ICookingService
{
    private readonly IDishRepository _dishRepository;
    private readonly IDrinkRepository _drinkRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMenuItemsPrepires _menuItemsPrepires;

    public CookingService(IServiceManager serviceManager, IRepositoryManager repositoryManager)
    {
        _menuItemsPrepires = serviceManager.MenuItemsPrepires;
        _dishRepository = repositoryManager.DishRepository;
        _drinkRepository = repositoryManager.DrinkRepository;
        _employeeRepository = repositoryManager.EmployeeRepository;
    }

    public IEnumerable<ReadyDrink?> PrepareDrinks(IEnumerable<Drink> drinks)
    {
        foreach (var drink in drinks) yield return _menuItemsPrepires.Prepare(drink) as ReadyDrink;
    }

    public IEnumerable<ReadyDish?> PrepareDishes(IEnumerable<Dish> dishes)
    {
        foreach (var dish in dishes) yield return _menuItemsPrepires.Prepare(dish) as ReadyDish;
    }

    public ReadyDrink? PrepareDrink(Drink drink)
    {
        return _menuItemsPrepires.Prepare(drink) as ReadyDrink;
    }

    public ReadyDish? PrepareDish(Dish dish)
    {
        return _menuItemsPrepires.Prepare(dish) as ReadyDish;
    }
}