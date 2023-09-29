using Common.Enums;

namespace Service.Items;

public class MenuItem
{
    public string Name { get; set; }
    public virtual MenuItemType MenuItemType { get; set; }
}