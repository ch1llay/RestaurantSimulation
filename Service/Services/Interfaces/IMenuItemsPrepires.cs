using Service.Items;
using Service.Models;

namespace Service.Services.Interfaces;

public interface IMenuItemsPrepires
{
    public ReadyDrink? Prepare(Drink drinks);

    public ReadyDish? Prepare(Dish dishes);
}