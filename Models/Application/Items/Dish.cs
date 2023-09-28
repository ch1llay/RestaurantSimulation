using Models.Enums;

namespace Models.Application.Items;

public class Dish : MenuItem
{
    public int Id { get; set; }
    public DishType DishType { get; set; }
    public override MenuItemType MenuItemType => MenuItemType.Dish;
}