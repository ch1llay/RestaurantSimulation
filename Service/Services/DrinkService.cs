using AutoMapper;
using Common.Enums;
using Domain.DI.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;
using Service.DI.Interfaces;
using Service.Models;
using Service.Services.Interfaces;

namespace Service.Services;

public class DrinkService : IDrinkDbService
{
    private readonly IDrinkRepository _drinkRepository;
    private readonly IMapper _mapper;

    public DrinkService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        _mapper = serviceManager.Mapper;
        _drinkRepository = repositoryManager.DrinkRepository;
    }


    public async Task<Drink> Add(Drink dishT)
    {
        return _mapper.Map<Drink>(await _drinkRepository.Add(_mapper.Map<DbDrink>(dishT)));
    }

    public async Task<IEnumerable<Drink>> GetAll()
    {
        return _mapper.Map<IEnumerable<Drink>>(await _drinkRepository.GetAll());
    }

    public async Task<IEnumerable<Drink>> GetByType(DrinkType type)
    {
        return _mapper.Map<IEnumerable<Drink>>(await _drinkRepository.GetByType(type));
    }

    public async Task<Drink> GetById(int id)
    {
        return _mapper.Map<Drink>(await _drinkRepository.GetById(id));
    }

    public async Task<IEnumerable<Drink>> GetByIds(IEnumerable<int> ids)
    {
        return _mapper.Map<IEnumerable<Drink>>(await _drinkRepository.GetByIds(ids));
    }
}