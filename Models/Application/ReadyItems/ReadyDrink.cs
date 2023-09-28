using Models.Application.Items;
using Models.Enums;

namespace Models.Application.ReadyItems;

public class ReadyDrink : ReadyOrderItem
{
    public GlassType GlassType { get; set; }
    public bool IsStraw { get; set; }
    public bool HasIce { get; set; }
    public Drink Drink { get; set; }

    public override MenuItemType MenuItemType => MenuItemType.Drink;

    public ReadyDrink AddIce()
    {
        HasIce = true;

        return this;
    }

    public ReadyDrink AddStraw()
    {
        IsStraw = true;

        return this;
    }
}