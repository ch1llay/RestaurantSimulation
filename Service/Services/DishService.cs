using AutoMapper;
using Domain.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Application.Items;
using Models.Domain;
using Models.Enums;
using Service.DI.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services;

public class DishService : IDishService
{
    private readonly IDishRepository _dishRepository;
    private readonly IMapper _mapper;

    public DishService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        _dishRepository = repositoryManager.DishRepository;
        _mapper = serviceManager.Mapper;
    }

    public Task<IEnumerable<Dish>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetAllAvailable()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetByType(DishType type)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dish>> GetByIds(IEnumerable<int> orderTIds)
    {
        throw new NotImplementedException();
    }

    public async Task<Dish> Add(Dish dishT)
    {
        var dishDb = await _dishRepository.Add(_mapper.Map<DbDish>(dishT));

        return _mapper.Map<Dish>(dishDb);
    }

    public async Task<List<Dish>> AddMany(List<Dish> dishes)
    {
        var dishesDb = await _dishRepository.AddRange(_mapper.Map<List<DbDish>>(dishes));

        return _mapper.Map<List<Dish>>(dishesDb);
    }

    public Task<List<Dish?>> GetByTypeAvailable(DishType dishType)
    {
        throw new NotImplementedException();
    }

    public Task<Dish?> Update(Dish dish)
    {
        throw new NotImplementedException();
    }

    public Task<bool?> Delete(int id)
    {
        throw new NotImplementedException();
    }
}