using AutoMapper;
using Common.Enums;
using Domain.DI.Interfaces;
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

    public Task<Employee> Add(Employee dishT)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetByType(EmployeeType type)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetByIds(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }
}