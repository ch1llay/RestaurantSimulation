using DataAccess.DI;
using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Domain;

namespace Domain.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IDataContext _dataContext;

    public ProductRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbProduct>> Get(IEnumerable<int> ids)
    {
        return _dataContext.EnumerableOrEmptyAsync<DbProduct>("", new { });
    }

    public Task<IEnumerable<DbProduct>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbProduct> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbProduct> Add(DbProduct model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbProduct> dbEmployees)
    {
        throw new NotImplementedException();
    }

    public DbProduct GetByName(string name)
    {
        throw new NotImplementedException();
    }
}