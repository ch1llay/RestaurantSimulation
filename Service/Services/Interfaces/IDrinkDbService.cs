using Common.Enums;
using Service.Models;

namespace Service.Services.Interfaces;

public interface IDrinkDbService : IDbService<Drink, DrinkType> { }