using DataAccess.Interfaces;
using Domain.Interfaces;
using Models.DbModels;

namespace Domain;

public class ProductRepository : IProductRepository
{
    private readonly IDataContext _dataContext;

    public ProductRepository(IDataContext dataContext)
    {
        _dataContext = dataContext;
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

    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbProduct> models)
    {
        throw new NotImplementedException();
    }

    public DbProduct GetByName(string name)
    {
        throw new NotImplementedException();
    }
}