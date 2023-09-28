using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Domain;

namespace Domain.Repositories;

public class CookingDishRepository : ICookingDishRepository
{
    private readonly IDataContext _dataContext;

    public CookingDishRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbCookingDish>> AddRange(IEnumerable<DbCookingDish> dbEmployees)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbCookingDish> GetByOrder(int orderId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbCookingDish> GetByProducts(IEnumerable<int> productIds)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbCookingDish>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbCookingDish>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbCookingDish> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbCookingDish> Add(DbCookingDish model)
    {
        throw new NotImplementedException();
    }
}