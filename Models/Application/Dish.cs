using Models.Enums;

namespace Models.Application;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public List<Product> Products { get; set; }
    public DishType DishType { get; set; }
}