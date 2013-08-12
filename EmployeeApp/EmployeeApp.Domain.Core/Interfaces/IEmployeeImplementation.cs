using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.Model;

namespace EmployeeApp.Domain.Core.Interfaces
{
    public interface IEmployeeImplementation
    {
        EmployeeModel Add(EmployeeModel entity);
        bool Update(EmployeeModel entity);
        bool Delete(EmployeeModel entity);
        EmployeeModel GetByEmployeeCode(int employeeCode);
        EmployeeModel GetByEmployeeName(string name);
        List<EmployeeModel> GetAllEmployeesByDate(DateTime startDate);
        List<EmployeeModel> GetAllEmployees();
    }
}
