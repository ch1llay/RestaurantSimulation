using Common.Enums;

namespace Service.Items;

public class ReadyDrink : ReadyItem
{
    public bool IsNeedStraw { get; set; }
    public bool IsNeedIce { get; set; }
    public bool IsNeedPlate { get; set; }
    public override MenuItemType MenuItemType => MenuItemType.Drink;

    public ReadyDrink AddStraw()
    {
        IsNeedStraw = true;

        return this;
    }
    
    public ReadyDrink AddIce()
    {
        IsNeedStraw = true;

        return this;
    }
}