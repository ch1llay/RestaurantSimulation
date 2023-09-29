using AutoMapper;
using DataAccess.DI.Interfaces;
using Domain.DI.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;

namespace Domain.DI;

public class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<IDishRepository> _lazyDishRepository;
    private readonly Lazy<IDrinkRepository> _lazyDrinkRepository;
    private readonly Lazy<IEmployeeRepository> _lazyEmployeeRepository;

    public RepositoryManager(IDataContextManager dataContextManager, IMapper mapper)
    {
        _lazyDishRepository = new Lazy<IDishRepository>(() => new DishRepository(dataContextManager));
        _lazyDrinkRepository = new Lazy<IDrinkRepository>(() => new DrinkRepository(dataContextManager));
        _lazyEmployeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(dataContextManager));
        Mapper = mapper;
    }


    public IDishRepository DishRepository => _lazyDishRepository.Value;
    public IDrinkRepository DrinkRepository => _lazyDrinkRepository.Value;
    public IEmployeeRepository EmployeeRepository => _lazyEmployeeRepository.Value;
    public IMapper Mapper { get; }
}