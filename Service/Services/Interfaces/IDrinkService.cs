using Models.Application;
using Models.Enums;

namespace Service.Services.Interfaces;

public interface IDrinkService
{
    public Task<IEnumerable<Drink>> GetByIds(IEnumerable<int> ids);
    public Task<IEnumerable<Drink>> GetByType(DrinkType type);
}