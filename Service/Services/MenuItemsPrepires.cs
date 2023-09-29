using Common.Enums;
using Service.DI.Interfaces;
using Service.Factories;
using Service.Items;
using Service.Models;
using Service.Services.Interfaces;

namespace Service.Services;

public class MenuItemsPrepires : IMenuItemsPrepires
{
    private readonly Dictionary<MenuItemType, PerformerContext> _creators =
        new Dictionary<MenuItemType, PerformerContext>
        {
            {MenuItemType.Dish, new PerformerContext(new CookFactory())},
            {
                MenuItemType.Drink, new PerformerContext(new BarFactory())
            }
        };

    public ReadyItem Prepare(MenuItem orderItem)
    {
        return _creators[orderItem.MenuItemType].Prepare(orderItem);
    }

    public IEnumerable<ReadyItem> Prepare(IEnumerable<MenuItem> orderItems)
    {
        foreach (var orderItem in orderItems)
        {
            yield return Prepare(orderItem);
        }
    }
}
