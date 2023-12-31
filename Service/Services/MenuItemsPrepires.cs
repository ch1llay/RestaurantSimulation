﻿using Common.Enums;
using Service.DI.Interfaces;
using Service.Factories;
using Service.Items;
using Service.Services.Interfaces;

namespace Service.Services;

public class MenuItemsPrepires : IMenuItemsPrepires
{
    private readonly Dictionary<MenuItemType, PerformerContext> _creators;
    private readonly IServiceManager _serviceManager;

    public MenuItemsPrepires(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;

        _creators =
            new Dictionary<MenuItemType, PerformerContext>
            {
                {MenuItemType.Dish, new PerformerContext(new CookFactory(), _serviceManager)},
                {
                    MenuItemType.Drink, new PerformerContext(new BarFactory(), _serviceManager)
                }
            };
    }

    public ReadyItem Prepare(MenuItem orderItem)
    {
        return _creators[orderItem.MenuItemType].Prepare(orderItem);
    }

    public IEnumerable<ReadyItem> Prepare(IEnumerable<MenuItem> orderItems)
    {
        foreach (var orderItem in orderItems) yield return Prepare(orderItem);
    }
}