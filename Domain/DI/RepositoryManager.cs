using AutoMapper;
using DataAccess.DI.Interfaces;
using Domain.DI.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;

namespace Domain.DI;

public class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<ICookingDishRepository> _lazyCookingDishRepository;
    private readonly Lazy<IDishRepository> _lazyDishRepository;
    private readonly Lazy<IDrinkRepository> _lazyDrinkRepository;
    private readonly Lazy<IEmployeeRepository> _lazyEmployeeRepository;
    private readonly Lazy<OrderRepository> _lazyOrderRepository;
    private readonly Lazy<IProductRepository> _lazyProductRepository;
    private readonly Lazy<ITableRepository> _lazyTableRepository;

    public RepositoryManager(IDataContextManager dataContextManager, IMapper mapper)
    {
        _lazyDishRepository = new Lazy<IDishRepository>(() => new DishRepository(dataContextManager));
        _lazyDrinkRepository = new Lazy<IDrinkRepository>(() => new DrinkRepository(dataContextManager));
        _lazyEmployeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(dataContextManager));
        _lazyOrderRepository = new Lazy<OrderRepository>(() => new OrderRepository(dataContextManager));
        _lazyTableRepository = new Lazy<ITableRepository>(() => new TableRepository(dataContextManager));
        _lazyProductRepository = new Lazy<IProductRepository>(() => new ProductRepository(dataContextManager));
        Mapper = mapper;
    }


    public IDishRepository DishRepository => _lazyDishRepository.Value;
    public IDrinkRepository DrinkRepository => _lazyDrinkRepository.Value;
    public ICookingDishRepository CookingDishRepository => _lazyCookingDishRepository.Value;
    public IEmployeeRepository EmployeeRepository => _lazyEmployeeRepository.Value;
    public OrderRepository OrderRepository => _lazyOrderRepository.Value;
    public ITableRepository TableRepository => _lazyTableRepository.Value;
    public IProductRepository ProductRepository => _lazyProductRepository.Value;
    public IMapper Mapper { get; }
}