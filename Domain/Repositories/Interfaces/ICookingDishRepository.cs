using Models.Domain;

namespace Domain.Repositories.Interfaces;

public interface ICookingDishRepository : IRepository<DbCookingDish>
{
    public IEnumerable<DbCookingDish> GetByOrder(int orderId);
    public IEnumerable<DbCookingDish> GetByProducts(IEnumerable<int> productIds);
}