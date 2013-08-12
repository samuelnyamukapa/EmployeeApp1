using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.Model;
using EmployeeApp.Service.Contracts;
namespace EmployeeApp.Service.Mappers
{
    public static class ServiceModelMapper
    {
        public static EmployeeSMC ConvertToEmployeeServiceModel(this EmployeeModel employeeModel)
        {
            return new EmployeeSMC()
            {
                Id = employeeModel.Id,
                EmployeeCode = employeeModel.EmployeeCode,
                Name = employeeModel.Name,
                StartDate = employeeModel.StartDate
            };
        }

        public static EmployeeModel ConvertToEmployeeModel(this EmployeeSMC employeeServiceModel)
        {
            return new EmployeeModel()
            {
                Id = employeeServiceModel.Id,
                EmployeeCode = employeeServiceModel.EmployeeCode,
                Name = employeeServiceModel.Name,
                StartDate = employeeServiceModel.StartDate
            };
        }

    }
}
