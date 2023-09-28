using Domain.DI.Interfaces;
using Models.Application;
using Models.Enums;
using Service.DI.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeService(IRepositoryManager repositoryManager, IServiceManager serviceManager)
    {
        
    }
    public Task<Employee> Add(Employee dishT)
    {
        throw new NotImplementedException();
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