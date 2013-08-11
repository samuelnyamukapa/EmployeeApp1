using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.Model;
using EmployeeApp.Data;

namespace EmployeeApp.Data.Mappers
{
    public static class Mapper
    {
        public static EmployeeModel ConvertToEmployeeModel(this Employee dbEmployee)
        {
            return new EmployeeModel()
            {
                Id = dbEmployee.Id,
                EmployeeCode = dbEmployee.EmployeeCode,
                Name = dbEmployee.Name,
                StartDate = dbEmployee.StartDate
            };
        }

        public static Employee ConvertToEmployeeModel(this EmployeeModel EmployeeModel)
        {
            return new Employee()
            {
                Id = EmployeeModel.Id,
                EmployeeCode = EmployeeModel.EmployeeCode,
                Name = EmployeeModel.Name,
                StartDate = EmployeeModel.StartDate,
                RowVersion = DateTime.Now.TimeOfDay
            };
        }

    }
}
