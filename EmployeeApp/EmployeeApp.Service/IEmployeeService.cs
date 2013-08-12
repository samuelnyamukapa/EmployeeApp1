using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EmployeeApp.Domain.Core;
using EmployeeApp.Model;
using EmployeeApp.Service.Contracts;

namespace EmployeeApp.Service
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [FaultContract(typeof(EmployeeFaultContract))]
        EmployeeSMC AddEmployee(EmployeeSMC entity);

        [OperationContract]
        [FaultContract(typeof(EmployeeFaultContract))]
        bool UpdateEmployee(EmployeeSMC entity);

        [OperationContract]
        [FaultContract(typeof(EmployeeFaultContract))]
        bool DeleteEmployee(EmployeeSMC entity);

        [OperationContract]
        [FaultContract(typeof(EmployeeFaultContract))]
        EmployeeSMC GetByEmployeeCode(int employeeCode);

        [OperationContract]
        [FaultContract(typeof(EmployeeFaultContract))]
        EmployeeSMC GetByEmployeeName(string name);

        [OperationContract]
        [FaultContract(typeof(EmployeeFaultContract))]
        List<EmployeeSMC> GetAllEmployeesByDate(DateTime startDate);

        [OperationContract]
        [FaultContract(typeof(EmployeeFaultContract))]
        List<EmployeeSMC> GetAllEmployeese();

    }
}
