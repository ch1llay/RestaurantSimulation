using Models.Application;
using Models.Enums;
using Service.Services.Interfaces;

namespace Service.Services;

public class DrinkService : IDrinkService
{
    public Task<IEnumerable<Drink>> GetByIds(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Drink>> GetByType(DrinkType type)
    {
        throw new NotImplementedException();
    }
}