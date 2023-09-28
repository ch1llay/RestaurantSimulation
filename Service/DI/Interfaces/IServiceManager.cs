using AutoMapper;
using Service.Services;
using Service.Services.Interfaces;

namespace Service.DI.Interfaces;

public interface IServiceManager
{
    public IDishService DishService { get; }
    public IDrinkService DrinkService { get; }
    public IEmployeeService EmployeeService { get; }
    public OrderService OrderService { get; }
    public IProductService ProductService { get; }

    public IMapper Mapper { get; }
}