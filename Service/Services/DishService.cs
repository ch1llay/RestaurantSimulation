using AutoMapper;
using Common.Enums;
using Domain.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Service.DI.Interfaces;
using Service.Models;
using Service.Services.Interfaces;

namespace Service.Services;

public class DishService : IDishDbService
{
    private readonly IDishRepository _dishRepository;
    private readonly IMapper _mapper;

    public DishService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        _dishRepository = repositoryManager.DishRepository;
        _mapper = serviceManager.Mapper;
    }

    public Task<Dish> Add(Dish dishT)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetByType(DishType type)
    {
        throw new NotImplementedException();
    }
}