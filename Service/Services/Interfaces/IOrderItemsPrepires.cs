using Models.Application;

namespace Service.Services.Interfaces;

public interface IOrderItemsPrepires
{
    public ReadyOrderItem Prepare(OrderItem orderItem);
    public IEnumerable<ReadyOrderItem> Prepare(IEnumerable<OrderItem> orderItem);
}