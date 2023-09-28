using AutoMapper;
using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;

namespace Domain.DI.Interfaces;

public interface IRepositoryManager
{
    public IDishRepository DishRepository { get; }
    public IDrinkRepository DrinkRepository { get; }
    public ICookingDishRepository CookingDishRepository { get; }
    public IEmployeeRepository EmployeeRepository { get; }
    public OrderRepository OrderRepository { get; }
    public ITableRepository TableRepository { get; }
    public IProductRepository ProductRepository { get; }
    public IMapper Mapper { get; }
    
}