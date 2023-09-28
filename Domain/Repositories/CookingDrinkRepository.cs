using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Domain;

namespace Domain.Repositories;

public class CookingDrinkRepository : ICookingDrinkRepository
{
    private readonly IDataContext _dataContext;

    public CookingDrinkRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbCookingDrink>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbCookingDrink>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbCookingDrink> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbCookingDrink> Add(DbCookingDrink model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbCookingDrink>> AddRange(IEnumerable<DbCookingDrink> dbEmployees)
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
}