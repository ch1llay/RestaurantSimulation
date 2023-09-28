using Models.Enums;

namespace Models.Application;

public class ReadyDish : ReadyOrderItem
{
    public PlateSize PlateSize { get; set; }
    public bool IsNeededGloves { get; set; }
    public Dish Dish { get; set; }
    public bool NeedSpoon { get; set; }
    public bool NeedFork { get; set; }
    public bool NeedKnife { get; set; }

    public override OrderItemType OrderItemType => OrderItemType.Dish;

}

