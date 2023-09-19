using Models.DTO;

namespace Domain.Interfaces;

public interface IDishRepository : IRepository<Dish>
{
    public IEnumerable<CookingDish> GetByProducts(IEnumerable<int> productIds);
}