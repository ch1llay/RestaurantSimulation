using Models.Application.Items;
using Models.Application.ReadyItems;
using Service.Workplaces.Interfaces;

namespace Service.Workplaces;

public class Kitchen : WorkPlace
{
    public override ReadyOrderItem? Modify(ReadyOrderItem orderItem)
    {
        var dish = orderItem as ReadyDish;

        dish?.AddSpoon()
            .MediumPlate();

        return dish;
    }
}