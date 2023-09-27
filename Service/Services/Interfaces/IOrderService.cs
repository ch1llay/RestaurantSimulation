using Models.Application;
using Models.DTO;

namespace Service.Services.Interfaces;

public interface IOrderService
{
    Task<OrderDTO?> MakeOrder(Order order);
}