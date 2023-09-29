using Common.Enums;

namespace Service.Items;

public class ReadyDish : ReadyItem
{
    public bool IsNeedSpoon { get; set; }
    public override MenuItemType MenuItemType => MenuItemType.Drink;

    public ReadyDish AddSpoon()
    {
        IsNeedSpoon = true;

        return this;
    }
}