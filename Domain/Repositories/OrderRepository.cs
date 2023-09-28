using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Domain;

namespace Domain.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly IDataContext _dataContext;

    public OrderRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbOrder>> AddRange(IEnumerable<DbOrder> dbEmployees)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbOrder> GetByTableNumber(int tableNumber)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbOrder>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbOrder>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbOrder> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbOrder> Add(DbOrder model)
    {
        throw new NotImplementedException();
    }
}