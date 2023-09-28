using Models.Application;
using Models.Application.Items;
using Models.Application.ReadyItems;

namespace Service.Services.Interfaces;

public interface IOrderItemsPrepires
{
    public ReadyOrderItem Prepare(MenuItem menuItem);
    public IEnumerable<ReadyOrderItem> Prepare(IEnumerable<MenuItem> orderItem);
}