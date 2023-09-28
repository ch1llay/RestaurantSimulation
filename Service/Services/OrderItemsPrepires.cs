using Models.Application.Items;
using Models.Application.ReadyItems;
using Models.Enums;
using Service.Factories;
using Service.Services.Interfaces;

namespace Service.Services;

public class OrderItemsPrepires : IOrderItemsPrepires
{
    private readonly Dictionary<MenuItemType, PerformerContext> _creators =
        new()
        {
            {MenuItemType.Dish, new PerformerContext(new CookFactory())},
            {
                MenuItemType.Drink, new PerformerContext(new BarFactory())
            }
        };

    public ReadyOrderItem Prepare(MenuItem menuItem)
    {
        return _creators[menuItem.MenuItemType].Prepare(menuItem);
    }

    public IEnumerable<ReadyOrderItem> Prepare(IEnumerable<MenuItem> orderItems)
    {
        foreach (var orderItem in orderItems) yield return Prepare(orderItem);
    }
}