using Models.Application;
using Models.Application.Items;
using Models.Enums;

namespace Service.Services.Interfaces;

public interface IDrinkService : IMenuService<Drink, DrinkType> { }