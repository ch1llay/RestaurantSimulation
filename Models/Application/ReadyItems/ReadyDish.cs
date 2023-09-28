using Models.Application.Items;
using Models.Enums;

namespace Models.Application.ReadyItems;

public class ReadyDish : ReadyOrderItem
{
    public PlateSize PlateSize { get; set; }
    public bool IsNeededGloves { get; set; }
    public Dish Dish { get; set; }
    public bool NeedSpoon { get; set; }
    public bool NeedFork { get; set; }
    public bool NeedKnife { get; set; }

    public override MenuItemType MenuItemType => MenuItemType.Dish;

    public ReadyDish AddSpoon()
    {
        NeedSpoon = true;

        return this;
    }

    public ReadyDish AddFork()
    {
        NeedFork = true;

        return this;
    }

    public ReadyDish AddGloves()
    {
        IsNeededGloves = true;

        return this;
    }

    public ReadyDish AddKnife()
    {
        NeedKnife = true;

        return this;
    }


    public ReadyDish DeepPlate()
    {
        PlateSize = PlateSize.Deep;

        return this;
    }

    public ReadyDish MediumPlate()
    {
        PlateSize = PlateSize.Medium;

        return this;
    }

    public ReadyDish SmallPlate()
    {
        PlateSize = PlateSize.Small;

        return this;
    }
}