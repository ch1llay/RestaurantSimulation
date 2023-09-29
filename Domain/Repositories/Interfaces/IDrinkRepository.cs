using Common.Enums;
using Domain.Models;

namespace Domain.Repositories.Interfaces;

public interface IDrinkRepository : IRepository<DbDrink, DrinkType> { }