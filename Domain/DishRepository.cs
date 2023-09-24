using Domain.Interfaces;
using Models.DbModels;

namespace Domain;

public class DishRepository : IDishRepository
{
    public Task<IEnumerable<Dish>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<Dish> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Dish> Add(Dish model)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Dish> AddRange(IEnumerable<Dish> models)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CookingDish> GetByProducts(IEnumerable<int> productIds)
    {
        throw new NotImplementedException();
    }
}