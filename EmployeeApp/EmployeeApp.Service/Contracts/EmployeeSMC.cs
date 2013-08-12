using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeApp.Service.Contracts
{
    [DataContract]
    public class EmployeeSMC
    {
         [DataMember]
        public int Id { get; set; }
         [DataMember]
        public string Name { get; set; }
         [DataMember]
        public int EmployeeCode { get; set; }
         [DataMember]
        public DateTime StartDate { get; set; }
    }
}
