using Common.Enums;

namespace Service.Items;

public class ReadyDish : ReadyItem
{
    public string Emoji { get; set; }
    public bool IsNeedSpoon { get; set; }
    public override MenuItemType MenuItemType => MenuItemType.Dish;

    public ReadyDish AddSpoon()
    {
        IsNeedSpoon = true;

        return this;
    }
}