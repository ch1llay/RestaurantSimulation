using Domain.DI.Interfaces;
using Models.Application;
using Models.Application.Items;
using Models.Enums;
using Service.DI.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services;

public class DishService : IDishService
{
    public DishService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        
    }
    public Task<IEnumerable<Dish>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetAllAvailable()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetByType(DishType type)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetByIds(IEnumerable<int> orderTIds)
    {
        throw new NotImplementedException();
    }

    public Task<Dish> Add(Dish dishT)
    {
        throw new NotImplementedException();
    }

    public Task<List<Dish?>> AddMany(List<Dish> dishes)
    {
        throw new NotImplementedException();
    }

    public Task<List<Dish?>> GetByTypeAvailable(DishType dishType)
    {
        throw new NotImplementedException();
    }

    public Task<Dish?> Update(Dish dish)
    {
        throw new NotImplementedException();
    }

    public Task<bool?> Delete(int id)
    {
        throw new NotImplementedException();
    }
}