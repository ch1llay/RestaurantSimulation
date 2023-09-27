using Models.Application;
using Models.Enums;
using Service.Services.Interfaces;

namespace Service.Services;

public class DrinkService : IDrinkService
{
    public Task<List<Drink>> GetByIds(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<List<Drink>> GetByType(DrinkType type)
    {
        throw new NotImplementedException();
    }
}