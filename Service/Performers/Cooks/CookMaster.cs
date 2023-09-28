using Models.Application.Items;
using Models.Application.ReadyItems;
using Models.Enums;
using Service.Performers.Interfaces;

namespace Service.Performers.Cooks;

public class CookMaster : Performer
{
    public Dictionary<DishType, Cook> _performers = new Dictionary<DishType, Cook>
    {
        {DishType.Cold, new ColdCook()},
        {DishType.Hot, new HotCook()},
        {DishType.Confectionery, new ConfectioneryCook()}
    };
    public override ReadyOrderItem Prepare(MenuItem? item)
    {
        var dish = item as Dish;
        return _performers[dish.DishType].Prepare(dish);

    }

    public override IEnumerable<ReadyOrderItem> Prepare(IEnumerable<MenuItem> sourceItems)
    {
        foreach (var sourceItem in sourceItems)
        {
            yield return Prepare(sourceItem);
        }
    }
}