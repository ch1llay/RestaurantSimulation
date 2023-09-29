using AutoMapper;
using Domain.DI.Interfaces;
using Service.DI.Interfaces;
using Service.Services;
using Service.Services.Interfaces;

namespace Service.DI;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IDishDbService> _lazyDishService;
    private readonly Lazy<IDrinkDbService> _lazyDrinkService;
    private readonly Lazy<IEmployeeDbService> _lazyEmployeeService;
    private readonly Lazy<IMenuItemsPrepires> _lazyMenuItemsPrepires;
    private readonly Lazy<ICookingService> _lazyCookingService;
    private readonly IMapper _mapper;
    

    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _lazyDishService = new Lazy<IDishDbService>(() => new DishService(repositoryManager, this));
        _lazyDrinkService = new Lazy<IDrinkDbService>(() => new DrinkService(repositoryManager, this));
        _lazyEmployeeService = new Lazy<IEmployeeDbService>(() => new EmployeeService(repositoryManager, this));
        _lazyMenuItemsPrepires = new Lazy<IMenuItemsPrepires>(() => new MenuItemsPrepires());
        _lazyCookingService = new Lazy<ICookingService>(() => new CookingService(this, repositoryManager));
        _mapper = mapper;
    }


    public IDishDbService DishDbService => _lazyDishService.Value;
    public IDrinkDbService DrinkService => _lazyDrinkService.Value;
    public IEmployeeDbService EmployeeDbService => _lazyEmployeeService.Value;
    public ICookingService CookingService => _lazyCookingService.Value;
    public IMenuItemsPrepires MenuItemsPrepires => _lazyMenuItemsPrepires.Value;
    public IMapper Mapper => _mapper;
}
