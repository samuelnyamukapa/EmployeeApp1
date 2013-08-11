using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace EmployeeApp.Data.Repositories
{
    public interface IEmployee : IRepository<Employee>
    {
        IQueryable<Employee> GetBySearch(Expression<Func<Employee, bool>> search);
    }
}
