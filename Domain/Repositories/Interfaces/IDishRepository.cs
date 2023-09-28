using Models.Domain;
using Models.Enums;

namespace Domain.Repositories.Interfaces;

public interface IDishRepository : IRepository<DbDish>
{
    public IEnumerable<CookingDish> GetByType(DishType dishType);
}