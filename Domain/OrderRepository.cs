using Domain.Interfaces;
using Models.DTO;

namespace Domain;

public class OrderRepository : IOrderRepository
{
    public IEnumerable<DbOrder> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public DbOrder Get(int id)
    {
        throw new NotImplementedException();
    }

    public int Add(DbOrder model)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbOrder> AddRange(IEnumerable<DbOrder> models)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbOrder> GetByTableNumber(int tableNumber)
    {
        throw new NotImplementedException();
    }
}