using Models.Application;

namespace Service.Interfaces;

public interface IProductService
{
    public Task<Product> AddProduct(Product product);
}