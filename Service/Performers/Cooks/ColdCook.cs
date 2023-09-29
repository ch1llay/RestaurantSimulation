using Service.Items;
using Service.Models;
using Service.Performers.Interfaces;

namespace Service.Performers.Cooks;

public class ColdCook : Cook
{
    public override ReadyItem Prepare(MenuItem? item)
    {
        var dish = (Dish) item;

        return new ReadyDish();
    }

    public override IEnumerable<ReadyItem> Prepare(IEnumerable<MenuItem> sourceItems)
    {
        throw new NotImplementedException();
    }
}