using DataAccess.Interfaces;
using Domain.Interfaces;
using Models.DTO;

namespace Domain;

public class ProductRepository : IProductRepository
{
    private IDataContext _dataContext;
    
    public ProductRepository(IDataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public Task<IEnumerable<DbProduct>> Get(IEnumerable<int> ids)
    {
        return _dataContext.EnumerableOrEmpty<DbProduct>("", new { });
    }

    public Task<DbProduct> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbProduct> Add(DbProduct model)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbProduct> AddRange(IEnumerable<DbProduct> models)
    {
        throw new NotImplementedException();
    }

    public DbProduct GetByName(string name)
    {
        throw new NotImplementedException();
    }
}