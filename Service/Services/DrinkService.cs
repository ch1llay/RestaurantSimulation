using Common.Enums;
using Domain.DI.Interfaces;
using Service.DI.Interfaces;
using Service.Models;
using Service.Services.Interfaces;

namespace Service.Services;

public class DrinkService : IDrinkDbService
{
    public DrinkService(IRepositoryManager repositoryManager, IServiceManager serviceManager) { }
    public Task<Drink> Add(Drink dishT)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Drink>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Drink>> GetByType(DrinkType type)
    {
        throw new NotImplementedException();
    }
}