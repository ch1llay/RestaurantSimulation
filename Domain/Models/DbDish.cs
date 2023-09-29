using Common.Enums;

namespace Domain.Models;

public class DbDish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public DishType DishType { get; set; }
}