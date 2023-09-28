using Models.Application.Items;
using Models.Application.ReadyItems;
using Service.Workplaces.Interfaces;

namespace Service.Workplaces;

public class Bar : WorkPlace
{
    public override ReadyOrderItem? Modify(ReadyOrderItem orderItem)
    {
        var drink = orderItem as ReadyDrink;

        drink?.AddStraw()
            .AddIce();

        return drink;
    }
}