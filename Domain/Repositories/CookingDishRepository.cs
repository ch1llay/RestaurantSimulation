using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Domain;

namespace Domain.Repositories;

public class CookingDishRepository : ICookingDishRepository
{
    public CookingDishRepository(IDataContextManager dataContext)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<CookingDish> dbEmployees)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CookingDish> GetByOrder(int orderId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CookingDish> GetByProducts(IEnumerable<int> productIds)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CookingDish>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CookingDish>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<CookingDish> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CookingDish> Add(CookingDish model)
    {
        throw new NotImplementedException();
    }
}