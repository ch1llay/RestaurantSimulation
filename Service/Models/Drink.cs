using Common.Enums;
using Service.Items;

namespace Service.Models;

public class Drink : MenuItem
{
    public DrinkType DrinkType { get; set; } 
}