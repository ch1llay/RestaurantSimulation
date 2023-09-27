using Models.Application;
using Models.Enums;

namespace Service.Services.Interfaces;

public interface IDrinkService
{
    public Task<List<Drink>> GetByIds(IEnumerable<int> ids);
    public Task<List<Drink>> GetByType(DrinkType type);
}