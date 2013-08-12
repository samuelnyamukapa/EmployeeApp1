using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.Data;
using EmployeeApp.Data.Repositories;
using EmployeeApp.Model;
using EmployeeApp.Domain.Core.Interfaces;

namespace EmployeeApp.Domain.Core
{
    public class EmployeeImplementation : IEmployeeImplementation
    {
        IEmployee _repository;
        public EmployeeImplementation(IEmployee repository)
        {
            _repository = repository;
        }


        public EmployeeModel Add(EmployeeModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(EmployeeModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(EmployeeModel entity)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetByEmployeeCode(int employeeCode)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetByEmployeeName(string name)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAllEmployeesByDate(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
