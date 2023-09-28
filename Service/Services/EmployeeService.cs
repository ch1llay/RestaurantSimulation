using Domain.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Application;
using Models.Enums;
using Service.DI.Interfaces;
using Service.Services.Interfaces;
using AutoMapper;
using Models.Domain;

namespace Service.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    private IMapper _mapper;
    public EmployeeService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        _employeeRepository = repositoryManager.EmployeeRepository;
        _mapper = serviceManager.Mapper;
    }
    public async Task<Employee> Add(Employee employee)
    {
       var dbEmployee = _mapper.Map<DbEmployee>(employee);
       await _employeeRepository.Add(dbEmployee);

       return _mapper.Map<Employee>(dbEmployee);
    }

    public Task<List<Employee?>> AddMany(List<Employee> dishes)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetByIds(IEnumerable<int> orderTIds)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetAllAvailable()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetByType(EmployeeType type)
    {
        throw new NotImplementedException();
    }

    public Task<List<Employee?>> GetByTypeAvailable(EmployeeType dishType)
    {
        throw new NotImplementedException();
    }

    public Task<Employee?> Update(Employee dish)
    {
        throw new NotImplementedException();
    }

    public Task<bool?> Delete(int id)
    {
        throw new NotImplementedException();
    }
}