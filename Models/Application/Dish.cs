using Models.Enums;

namespace Models.Application;

public class Dish : OrderItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public IEnumerable<Product> Products { get; set; }
    public DishType DishType { get; set; }
    public override OrderItemType OrderItemType => OrderItemType.Dish;
}