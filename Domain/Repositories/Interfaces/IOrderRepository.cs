using Models.Domain;

namespace Domain.Repositories.Interfaces;

public interface IOrderRepository : IRepository<DbOrder>
{
    public IEnumerable<DbOrder> GetByTableNumber(int tableNumber);
}