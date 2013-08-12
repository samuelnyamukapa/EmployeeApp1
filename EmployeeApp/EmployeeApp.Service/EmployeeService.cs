using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.Service;
using EmployeeApp.Model;
using EmployeeApp.Domain.Core;
using EmployeeApp.Domain.Core.Interfaces;
using EmployeeApp.Service.Contracts;
using EmployeeApp.Service.Mappers;
using System.ServiceModel;


namespace EmployeeApp.Service
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeImplementation _employeeImplementation;
        public EmployeeService(IEmployeeImplementation employeeImplementation)
        {
            _employeeImplementation = employeeImplementation;
        }

        public EmployeeSMC AddEmployee(EmployeeSMC entity)
        {
            try
            {
                return _employeeImplementation.Add(entity.ConvertToEmployeeModel()).ConvertToEmployeeServiceModel();
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;
                string note = "could not Add Employee";
                throw new FaultException<EmployeeFaultContract>(new EmployeeFaultContract(errorMsg), note);
            }
        }

        public bool UpdateEmployee(EmployeeSMC entity)
        {
            try
            {
                return _employeeImplementation.Update(entity.ConvertToEmployeeModel());
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;
                string note = "could not Update Employee";
                throw new FaultException<EmployeeFaultContract>(new EmployeeFaultContract(errorMsg), note);
            }
        }

        public bool DeleteEmployee(EmployeeSMC entity)
        {
            try
            {
                return _employeeImplementation.Delete(entity.ConvertToEmployeeModel());
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;
                string note = "could not Delete Employee";
                throw new FaultException<EmployeeFaultContract>(new EmployeeFaultContract(errorMsg), note);
            }
        }

        public EmployeeSMC GetByEmployeeCode(int employeeCode)
        {
            try
            {
                return _employeeImplementation.GetByEmployeeCode(employeeCode).ConvertToEmployeeServiceModel();
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;
                string note = "could not Get Employee by Code";
                throw new FaultException<EmployeeFaultContract>(new EmployeeFaultContract(errorMsg), note);
            }
        }

        public EmployeeSMC GetByEmployeeName(string name)
        {
            try
            {
                return _employeeImplementation.GetByEmployeeName(name).ConvertToEmployeeServiceModel();
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;
                string note = "could not Get Employee by Name";
                throw new FaultException<EmployeeFaultContract>(new EmployeeFaultContract(errorMsg), note);
            }
        }

        public List<EmployeeSMC> GetAllEmployeesByDate(DateTime startDate)
        {
            try
            {
                List<EmployeeSMC> myList = new List<EmployeeSMC>();
                _employeeImplementation.GetAllEmployeesByDate(startDate).ForEach(x => myList.Add(x.ConvertToEmployeeServiceModel()));
                return myList;
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;
                string note = "could not Get Employee by Date";
                throw new FaultException<EmployeeFaultContract>(new EmployeeFaultContract(errorMsg), note);
            }
        }

        public List<EmployeeSMC> GetAllEmployeese()
        {
            try
            {
                List<EmployeeSMC> myList = new List<EmployeeSMC>();
                _employeeImplementation.GetAllEmployees().ForEach(x => myList.Add(x.ConvertToEmployeeServiceModel()));
                return myList;
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;
                string note = "could not Get All Employees";
                throw new FaultException<EmployeeFaultContract>(new EmployeeFaultContract(errorMsg), note);
            }
        }
    }
}
