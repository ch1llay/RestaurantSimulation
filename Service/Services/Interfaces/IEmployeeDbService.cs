
using Common.Enums;
using Service.Models;

namespace Service.Services.Interfaces;

public interface IEmployeeDbService : IDbService<Employee, EmployeeType> { }