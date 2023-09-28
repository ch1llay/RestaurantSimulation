using AutoMapper;
using Models.Application;
using Models.Application.Items;
using Models.Domain;

namespace RestourantSimulation;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<DbEmployee, Employee>().ReverseMap();
        CreateMap<DbDish, Dish>().ReverseMap();
        CreateMap<DbDrink, Drink>().ReverseMap();
        CreateMap<DbOrder, Order>().ReverseMap();
        CreateMap<DbProduct, Product>().ReverseMap();
    }
}