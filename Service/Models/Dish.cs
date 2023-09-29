using Common.Enums;
using Service.Items;

namespace Service.Models;

public class Dish : ReadyItem
{
    public DishType DishType { get; set; }
}