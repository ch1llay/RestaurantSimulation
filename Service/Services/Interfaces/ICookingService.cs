
using Service.Items;
using Service.Models;

namespace Service.Services.Interfaces;

public interface ICookingService
{
    public IEnumerable<ReadyDrink?> PrepareDrinks(IEnumerable<Drink> drinks);
    public IEnumerable<ReadyDish?> PrepareDishes(IEnumerable<Dish> dishes);
    
    public ReadyDrink? PrepareDrink(Drink drink);
    public ReadyDish? PrepareDish(Dish dish);
}