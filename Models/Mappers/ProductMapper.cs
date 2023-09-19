using Models.Application;
using Models.DTO;

namespace Models.Mappers;

public static class ProductMapper
{
    public static Product ToApplication(this DbProduct product)
    {
        return new Product();
    }

    public static DbProduct ToDb(this Product product)
    {
        return new DbProduct();
    }
}