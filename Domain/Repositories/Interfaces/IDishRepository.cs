using Models.Domain;
using Models.Enums;

namespace Domain.Repositories.Interfaces;

public interface IDishRepository : IRepository<DbDish>
{
    public Task<IEnumerable<DbDish>> GetByType(DishType dishType);
}