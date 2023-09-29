
using Service.Items;
using Service.Workplaces.Interfaces;

namespace Service.Workplaces;

public class Bar : WorkPlace
{
    public override ReadyItem? Modify(ReadyItem orderItem)
    {
        var drink = orderItem as ReadyDrink;

        drink?.AddStraw()
            .AddIce();

        return drink;
    }
}