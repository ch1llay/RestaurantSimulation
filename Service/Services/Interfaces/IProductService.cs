using Models.Application;

namespace Service.Services.Interfaces;

public interface IProductService
{
    public Task<Product> AddProduct(Product product);
}