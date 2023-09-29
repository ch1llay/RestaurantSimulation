using AutoMapper;
using Domain.Models;
using Service.Models;

namespace RestaurantSimulation;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<DbEmployee, Employee>().ReverseMap();
        CreateMap<Employee, DbEmployee>().ReverseMap();
        CreateMap<DbDish, Dish>().ReverseMap();
        CreateMap<Dish, DbDish>().ReverseMap();
        CreateMap<DbDrink, Drink>().ReverseMap();
        CreateMap<Drink, DbDrink>().ReverseMap();
    }
}