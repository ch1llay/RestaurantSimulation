using AutoMapper;
using Domain.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Application;
using Models.Domain;
using Models.Enums;
using Service.DI.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

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

    public async Task<List<Employee>> AddMany(List<Employee> employees
    )
    {
        var employeesDb = await _employeeRepository.AddRange(_mapper.Map<List<DbEmployee>>(employees));

        return _mapper.Map<List<Employee>>(employeesDb);
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