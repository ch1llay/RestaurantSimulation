using AutoMapper;
using Models.Application;
using Models.Domain;

namespace RestourantSimulation;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {			
        CreateMap<DbEmployee, Employee>().ReverseMap();
    }
}