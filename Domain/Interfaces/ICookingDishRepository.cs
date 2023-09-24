using Models.DbModels;

namespace Domain.Interfaces;

public interface ICookingDishRepository : IRepository<CookingDish>
{
    public IEnumerable<CookingDish> GetByOrder(int orderId);
    public IEnumerable<CookingDish> GetByProducts(IEnumerable<int> productIds);
}