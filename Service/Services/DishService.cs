using AutoMapper;
using Common.Enums;
using Domain.DI.Interfaces;
using Domain.Models;
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

    public async Task<Dish> Add(Dish dishT)
    {
        return _mapper.Map<Dish>(await _dishRepository.Add(_mapper.Map<DbDish>(dishT)));
    }

    public async Task<IEnumerable<Dish>> GetAll()
    {
        return _mapper.Map<IEnumerable<Dish>>(await _dishRepository.GetAll());
    }

    public async Task<IEnumerable<Dish>> GetByType(DishType type)
    {
        return _mapper.Map<IEnumerable<Dish>>(await _dishRepository.GetByType(type));
    }

    public async Task<Dish> GetById(int id)
    {
        return _mapper.Map<Dish>(await _dishRepository.GetById(id));
    }

    public async Task<IEnumerable<Dish>> GetByIds(IEnumerable<int> ids)
    {
        return _mapper.Map<IEnumerable<Dish>>(await _dishRepository.GetByIds(ids));
    }
}