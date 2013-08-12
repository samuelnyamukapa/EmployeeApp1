using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EmployeeApp.Service;
using EmployeeApp.Domain.Core;
using EmployeeApp.Domain.Core.Interfaces;

namespace EmployeeApp.Web.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    public class EmployeeService : EmployeeApp.Service.EmployeeService
    {
         public EmployeeService (IEmployeeImplementation employeeImplementation): base(employeeImplementation)
            {

            }
    }
}
