using Common.Enums;
using Service.Items;
using Service.Models;
using Service.Performers.Interfaces;

namespace Service.Performers.Cooks;

public class CookMaster : Performer
{
    public Dictionary<DishType, Cook> _performers = new()
    {
        {DishType.Cold, new ColdCook()},
        {DishType.Hot, new HotCook()},
        {DishType.Сonfectionery, new ConfectioneryCook()}
    };

    public override ReadyItem Prepare(MenuItem? item)
    {
        var dish = (Dish) item;

        return _performers[dish.DishType].Prepare(dish);
    }

    public override IEnumerable<ReadyItem> Prepare(IEnumerable<MenuItem> sourceItems)
    {
        foreach (var sourceItem in sourceItems) yield return Prepare(sourceItem);
    }
}