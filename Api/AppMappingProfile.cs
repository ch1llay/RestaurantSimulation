using AutoMapper;
using Domain.Models;
using Service.Models;

namespace RestourantSimulation;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<DbEmployee, Employee>().ReverseMap();
        CreateMap<DbDish, Dish>().ReverseMap();
        CreateMap<DbDrink, Drink>().ReverseMap();
    }
}