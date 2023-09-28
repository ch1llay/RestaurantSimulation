using Domain.DI.Interfaces;
using Models.Application;
using Models.Application.Items;
using Models.Enums;
using Service.DI.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services;

public class DrinkService : IDrinkService
{
    public DrinkService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        
    }
    public Task<IEnumerable<Drink>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Drink>> GetAllAvailable()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Drink>> GetByType(DrinkType type)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Drink>> GetByIds(IEnumerable<int> orderTIds)
    {
        throw new NotImplementedException();
    }

    public Task<Drink> Add(Drink dishT)
    {
        throw new NotImplementedException();
    }

    public Task<List<Drink?>> AddMany(List<Drink> dishes)
    {
        throw new NotImplementedException();
    }

    public Task<List<Drink?>> GetByTypeAvailable(DrinkType dishType)
    {
        throw new NotImplementedException();
    }

    public Task<Drink?> Update(Drink dish)
    {
        throw new NotImplementedException();
    }

    public Task<bool?> Delete(int id)
    {
        throw new NotImplementedException();
    }
}