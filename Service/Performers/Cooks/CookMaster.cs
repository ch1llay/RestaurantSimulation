using Models.Application;
using Models.Enums;
using Service.Performers.Interfaces;

namespace Service.Performers;

public class CookMaster : Performer
{
    public Dictionary<DishType, Cook> _performers = new Dictionary<DishType, Cook>
    {
        {DishType.Cold, new ColdCook()},
        {DishType.Hot, new HotCook()},
        {DishType.Confectionery, new ConfectioneryCook()}
    };
    public override ReadyOrderItem Prepare(OrderItem? item)
    {
        var dish = item as Dish;
        return _performers[dish.DishType].Prepare(dish);

    }

    public override IEnumerable<ReadyOrderItem> Prepare(IEnumerable<OrderItem> sourceItems)
    {
        foreach (var sourceItem in sourceItems)
        {
            yield return Prepare(sourceItem);
        }
    }
}