using Domain.Interfaces;
using Models.DTO;

namespace Domain;

public class CookingDishRepository : ICookingDishRepository
{
    public IEnumerable<CookingDish> AddRange(IEnumerable<CookingDish> models)
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

    public Task<CookingDish> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CookingDish> Add(CookingDish model)
    {
        throw new NotImplementedException();
    }
}