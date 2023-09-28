using Models.Application.Items;

namespace Service.Services.Interfaces;

public interface ICookingService
{
    public IEnumerable<ReadyDrink?> PrepareDrinks(IEnumerable<Drink> drinks);
    public IEnumerable<ReadyDish?> PrepareDishes(IEnumerable<Dish> dishes);
}