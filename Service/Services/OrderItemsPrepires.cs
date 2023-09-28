using Models.Application;
using Models.Enums;
using Service.Factories;
using Service.Performers.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services;

public class OrderItemsPrepires : IOrderItemsPrepires
{
    private readonly Dictionary<OrderItemType, PerformerContext> _creators =
        new Dictionary<OrderItemType, PerformerContext>
        {
            {OrderItemType.Dish, new PerformerContext(new CookFactory())},
            {
                OrderItemType.Drink, new PerformerContext(new BarFactory())
            }
        };
    
    public ReadyOrderItem Prepare(OrderItem orderItem)
    {
        return _creators[orderItem.OrderItemType].Prepare(orderItem);
    }

    public IEnumerable<ReadyOrderItem> Prepare(IEnumerable<OrderItem> orderItems)
    {
        foreach (var orderItem in orderItems)
        {
            yield return Prepare(orderItem);
        }
    }
}