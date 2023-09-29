using Common.Enums;
using Service.Items;

namespace Service.Models;

public class Drink : MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public DrinkType DrinkType { get; set; } 
}