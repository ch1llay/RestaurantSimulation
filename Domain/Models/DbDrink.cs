using Common.Enums;

namespace Domain.Models;

public class DbDrink
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public DrinkType DrinkType { get; set; }
}