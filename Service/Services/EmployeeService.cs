using AutoMapper;
using Common.Enums;
using Domain.DI.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;
using Service.DI.Interfaces;
using Service.Models;
using Service.Services.Interfaces;

namespace Service.Services;

public class EmployeeService : IEmployeeDbService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeeService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        _employeeRepository = repositoryManager.EmployeeRepository;
        _mapper = serviceManager.Mapper;
    }

    public async Task<Employee> Add(Employee dishT)
    {
        return _mapper.Map<Employee>(await _employeeRepository.Add(_mapper.Map<DbEmployee>(dishT)));
    }

    public async Task<IEnumerable<Employee>> GetAll()
    {
        return _mapper.Map<IEnumerable<Employee>>(await _employeeRepository.GetAll());
    }

    public async Task<IEnumerable<Employee>> GetByType(EmployeeType type)
    {
        return _mapper.Map<IEnumerable<Employee>>(await _employeeRepository.GetByType(type));
    }

    public async Task<Employee> GetById(int id)
    {
        return _mapper.Map<Employee>(await _employeeRepository.GetById(id));
    }

    public async Task<IEnumerable<Employee>> GetByIds(IEnumerable<int> ids)
    {
        return _mapper.Map<IEnumerable<Employee>>(await _employeeRepository.GetByIds(ids));
    }
}