using Service.Items;
using Service.Models;

namespace Service.Services.Interfaces;

public interface IMenuItemsPrepires
{
    public ReadyItem? Prepare(MenuItem item);

    public IEnumerable<ReadyItem>? Prepare(IEnumerable<MenuItem> items);
}