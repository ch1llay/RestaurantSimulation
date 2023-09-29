using AutoMapper;
using Domain.Models;
using Service.Models;

namespace RestaurantSimulation;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<DbEmployee, Employee>().ReverseMap();
        CreateMap<DbDish, Dish>().ReverseMap();
        CreateMap<DbDrink, Drink>().ReverseMap();
    }
}