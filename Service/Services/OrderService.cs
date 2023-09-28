using Domain.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Application;
using Models.Application.Items;
using Models.DTO;
using Service.DI.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services;

public class OrderService : IOrderService
{
    private readonly ICookingService _cookingService;
    private readonly IDishService _dishService;
    private readonly IDrinkService _drinkService;
    private readonly ITableRepository _tableRepository;

    public OrderService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        _dishService = serviceManager.DishService;
    }

    public async Task<OrderDTO?> MakeOrder(Order order)
    {
        var availableTable = await _tableRepository.GetAvailableByPeopleCapacity(order.PeopleAmount);

        if (availableTable == null)
        {
            return null;
        }

        var dishes = await _dishService.GetByIds(order.DishIds);
        var drinks = await _drinkService.GetByIds(order.DrinkIds);

        var readyDrinks = _cookingService.PrepareDrinks(drinks);
        var readyDishes = _cookingService.PrepareDishes(dishes);

        var enumerable = readyDrinks as ReadyDrink[] ?? readyDrinks.ToArray();

        return new OrderDTO
        {
            Drinks = enumerable.ToList(),
            Dishes = readyDishes.ToList(),
            TotalAmount = readyDishes.Sum(r => r.Dish.Cost) + enumerable.Sum(r => r.Drink.Cost)
        };
    }

    public Task<Order?> GetOrders()
    {
        throw new NotImplementedException();
    }
}