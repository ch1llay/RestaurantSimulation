using Models.DbModels;

namespace Service.Interfaces;

public interface IEmployeeService
{
    public Task<DbEmployee> Add(DbEmployee employee);
    public Task<DbEmployee> Get(int id);
}