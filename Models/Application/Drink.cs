using Models.Enums;

namespace Models.Application;

public class Drink : OrderItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Volume { get; set; }
    public DrinkType DrinkType { get; set; }
    public override OrderItemType OrderItemType => OrderItemType.Dish;

}