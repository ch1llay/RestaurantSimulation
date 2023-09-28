using Models.Enums;

namespace Models.Application.Items;

public class Drink : MenuItem
{
    public int Id { get; set; }
    public int Volume { get; set; }
    public DrinkType DrinkType { get; set; }
    public override MenuItemType MenuItemType => MenuItemType.Dish;
}