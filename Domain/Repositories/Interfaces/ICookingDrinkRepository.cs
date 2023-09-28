using Models.Domain;

namespace Domain.Repositories.Interfaces;

public interface ICookingDrinkRepository : IRepository<DbCookingDrink>
{
    public IEnumerable<DbCookingDish> GetByOrder(int orderId);
    public IEnumerable<DbCookingDish> GetByProducts(IEnumerable<int> productIds);
}