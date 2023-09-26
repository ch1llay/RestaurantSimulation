﻿using Domain.Interfaces;
using Models.DbModels;
using Service.Interfaces;

namespace Service;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }

    public async Task<DbEmployee> Add(DbEmployee employee)
    {
        employee = await employeeRepository.Add(employee);

        return employee;
    }

    public async Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbEmployee> employees)
    {
        var employeesAdded = await employeeRepository.AddRange(employees);

        return employeesAdded;
    }


    public Task<DbEmployee> Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<DbEmployee>> GetAll()
    {
        return await employeeRepository.GetAll();
    }
}