
using Service.Items;
using Service.Workplaces.Interfaces;

namespace Service.Workplaces;

public class Kitchen : WorkPlace
{
    public override ReadyItem? Modify(ReadyItem orderItem)
    {
        var dish = orderItem as ReadyDish;

        dish?.AddSpoon();

        return dish;
    }
}