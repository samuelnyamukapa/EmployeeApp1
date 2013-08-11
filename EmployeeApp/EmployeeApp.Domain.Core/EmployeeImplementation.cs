using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.Data;
using EmployeeApp.Data.Repositories;
using EmployeeApp.Model;

namespace EmployeeApp.Domain.Core
{
    public class EmployeeImplementation
    {
        IEmployee _repository;
        public EmployeeImplementation(IEmployee repository)
        {
            _repository = repository;
        }

    }
}
