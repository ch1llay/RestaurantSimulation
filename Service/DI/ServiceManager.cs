using AutoMapper;
using Domain.DI.Interfaces;
using Service.DI.Interfaces;
using Service.Services;
using Service.Services.Interfaces;

namespace Service.DI;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IDishService> _lazyDishService;
    private readonly Lazy<IDrinkService> _lazyDrinkService;
    private readonly Lazy<IEmployeeService> _lazyEmployeeService;
    private readonly Lazy<OrderService> _lazyOrderService;
    private readonly Lazy<IProductService> _lazyProductService;

    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _lazyDishService = new Lazy<IDishService>(() => new DishService(repositoryManager, this));
        _lazyDrinkService = new Lazy<IDrinkService>(() => new DrinkService(repositoryManager, this));
        _lazyEmployeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repositoryManager, this));
        _lazyOrderService = new Lazy<OrderService>(() => new OrderService(repositoryManager, this));
        _lazyProductService = new Lazy<IProductService>(() => new ProductService(repositoryManager, this));
        Mapper = mapper;
    }


    public IDishService DishService => _lazyDishService.Value;
    public IDrinkService DrinkService => _lazyDrinkService.Value;
    public IEmployeeService EmployeeService => _lazyEmployeeService.Value;
    public OrderService OrderService => _lazyOrderService.Value;
    public IProductService ProductService => _lazyProductService.Value;
    public IMapper Mapper { get; }
}