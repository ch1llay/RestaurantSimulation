﻿using Domain.Interfaces;
using Models.Application;
using Models.Mappers;
using Service.Interfaces;

namespace Service;

public class ProductService : IProductService
{
    private IProductRepository _productRepository;
    
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> AddProduct(Product product)
    {
        return (await _productRepository.Add(product.ToDb())).ToApplication();
    }
}