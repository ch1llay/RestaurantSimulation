using Domain.Interfaces;
using Models.Application;
using Models.DTO;
using Service.Services.Interfaces;

namespace Service.Services;

public class OrderService : IOrderService
{
    private readonly IDishService _dishService;
    private readonly IDrinkService _drinkService;
    private readonly ITableRepository _tableRepository;
    
    public OrderService(IDishService dishService, IDrinkService drinkService, ITableRepository tableRepository)
    {
        _dishService = dishService;
        _drinkService = drinkService;
        _tableRepository = tableRepository;
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
        
        

        return new OrderDTO();
    }
}