using Common.Enums;
using Domain.Models;

namespace Domain.Repositories.Interfaces;

public interface IDishRepository : IRepository<DbDish, DishType>
{
}