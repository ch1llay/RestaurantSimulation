using DataAccess.Interfaces;
using Domain.Interfaces;
using Models.Domain;

namespace Domain;

public class CookingDishRepository : ICookingDishRepository
{
    public CookingDishRepository(IDataContext dataContext)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<CookingDish> models)
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