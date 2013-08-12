using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.Data;
using EmployeeApp.Data.Repositories;
using EmployeeApp.Model;
using EmployeeApp.Domain.Core.Interfaces;
using EmployeeApp.Data.Mappers;

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
            return _repository.Add(entity.ConvertToEmployeeModel()).ConvertToEmployeeModel();
        }

        public bool Update(EmployeeModel entity)
        {
            return _repository.Update(entity.ConvertToEmployeeModel());
        }

        public bool Delete(EmployeeModel entity)
        {
            return _repository.Delete(entity.ConvertToEmployeeModel());
        }

        public EmployeeModel GetByEmployeeCode(int employeeCode)
        {
            return _repository.Get(x=> x.EmployeeCode==employeeCode).ConvertToEmployeeModel();
        }

        public EmployeeModel GetByEmployeeName(string name)
        {
            return _repository.Get(x => x.Name == name).ConvertToEmployeeModel();
        }

        public List<EmployeeModel> GetAllEmployeesByDate(DateTime startDate)
        {
            List<EmployeeModel> myList = new List<EmployeeModel>();
            _repository.GetBySearch(x=> x.StartDate ==startDate).ToList().ForEach(x => myList.Add(x.ConvertToEmployeeModel()));
            return myList;
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> myList = new List<EmployeeModel>();
            _repository.GetAll().ToList().ForEach(x => myList.Add(x.ConvertToEmployeeModel()));
            return myList;
        }
    }
}
