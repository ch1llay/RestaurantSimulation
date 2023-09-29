using AutoMapper;
using Domain.Repositories;
using Domain.Repositories.Interfaces;

namespace Domain.DI.Interfaces;

public interface IRepositoryManager
{
    public IDishRepository DishRepository { get; }
    public IDrinkRepository DrinkRepository { get; }
    public IEmployeeRepository EmployeeRepository { get; }
    public IMapper Mapper { get; }
}