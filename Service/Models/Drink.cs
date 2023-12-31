﻿using Common.Enums;
using Service.Items;

namespace Service.Models;

public class Drink : MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public override MenuItemType MenuItemType => MenuItemType.Drink;
    public DrinkType DrinkType { get; set; }
}