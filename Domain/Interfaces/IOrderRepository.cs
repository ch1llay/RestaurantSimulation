using Models.DTO;

namespace Domain.Interfaces;

public interface IOrderRepository : IRepository<DbOrder>
{
    public IEnumerable<DbOrder> GetByTableNumber(int tableNumber);
}