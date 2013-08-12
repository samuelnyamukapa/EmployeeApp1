using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeApp.Service.Contracts
{
    [DataContract]
    public class EmployeeFaultContract
    {
        public EmployeeFaultContract(string message)
        {
            FaultMessage = message;
        }

        [DataMember]
        public string FaultMessage;

    }
}
