using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace EmployeeApp.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, EmployeeContainer>, IEmployee
    {
        public override bool Update(Employee entity)
        {
            entity.EntityKey = new EntityKey("EmployeeContainer.Employees", "Id", entity.Id);
            return base.Update(entity);
        }

        public override bool Delete(Employee entity)
        {
            entity.EntityKey = new EntityKey("EmployeeContainer.Employees", "Id", entity.Id);
            return base.Delete(entity);
        }

        public IQueryable<Employee> GetBySearch(Expression<Func<Employee, bool>> search)
        {
            return this.Context.Employees.Where(search);
        }
    }
}
