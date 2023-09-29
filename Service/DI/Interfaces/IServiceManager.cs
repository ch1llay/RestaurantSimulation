using AutoMapper;
using Service.Services.Interfaces;

namespace Service.DI.Interfaces;

public interface IServiceManager
{
    public IDishDbService DishDbService { get; }
    public IDrinkDbService DrinkService { get; }
    public IEmployeeDbService EmployeeDbService { get; }
    public ICookingService CookingService { get; }
    public IMenuItemsPrepires MenuItemsPrepires { get; }
    public IMapper Mapper { get; }
}