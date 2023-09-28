using Domain.Interfaces;
using Models.Application;
using Models.DTO;
using Service.Preparing.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services;

public class OrderService : IOrderService
{
    private readonly IDishService _dishService;
    private readonly IDrinkService _drinkService;
    private readonly ITableRepository _tableRepository;
    private readonly ICookingService _cookingService;
    public OrderService(IDishService dishService, IDrinkService drinkService, ITableRepository tableRepository, ICookingService cookingService)
    {
        _dishService = dishService;
        _drinkService = drinkService;
        _tableRepository = tableRepository;
        _cookingService = cookingService;
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

        return new OrderDTO
        {
            Drinks = readyDrinks.ToList(),
            Dishes = readyDishes.ToList()
        };

    }
    
}