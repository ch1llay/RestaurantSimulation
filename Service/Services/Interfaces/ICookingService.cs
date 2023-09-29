
using Service.Items;
using Service.Models;

namespace Service.Services.Interfaces;

public interface ICookingService
{
    public IEnumerable<ReadyDrink?> PrepareDrinks(IEnumerable<int> ids);
    public IEnumerable<ReadyDish?> PrepareDishes(IEnumerable<int> ids);
}