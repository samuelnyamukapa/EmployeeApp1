﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeApp.Data.Repositories
{
    public interface IRepository<TType>
    {
        TType Add(TType entity);

        bool Update(TType entity);

        bool Delete(TType entity);

        TType Get(Expression<Func<TType, bool>> filter);

        ICollection<TType> GetAll();
    }
}
