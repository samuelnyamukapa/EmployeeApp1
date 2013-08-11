﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Metadata.Edm;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;

namespace EmployeeApp.Data.Repositories
{
    public abstract class GenericRepository<TType, TContext> : IRepository<TType>
        where TContext : ObjectContext, new()
        where TType : EntityObject
    {
        private readonly TContext _entity = new TContext();

        protected TContext Context
        {
            get { return this._entity; }
        }

        protected string GetEntitySetName(string entityTypeName)
        {
            return this._entity.MetadataWorkspace
                                .GetEntityContainer(this._entity.DefaultContainerName, DataSpace.CSpace)
                                .BaseEntitySets
                                .Single(x => x.ElementType.Name.Equals(entityTypeName)).Name;
        }

        public TType Add(TType entity)
        {
            this._entity.AddObject(this.GetEntitySetName(typeof(TType).Name), entity);
            this._entity.SaveChanges();
            return entity;
        }

        public virtual bool Update(TType entity)
        {
            this._entity.AttachTo(this.GetEntitySetName(typeof(TType).Name), entity);
            this._entity.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
            this._entity.SaveChanges(SaveOptions.DetectChangesBeforeSave);
            return true;
        }

        public virtual bool Delete(TType entity)
        {
            this._entity.AttachTo(this.GetEntitySetName(typeof(TType).Name), entity);
            this._entity.ObjectStateManager.ChangeObjectState(entity, EntityState.Deleted);
            this._entity.SaveChanges();
            return true;
        }

        public TType Get(Expression<Func<TType, bool>> filter)
        {
            return this._entity.CreateObjectSet<TType>().SingleOrDefault(filter);
        }

        public ICollection<TType> GetAll()
        {
            return this._entity.CreateObjectSet<TType>().ToList();
        }
    }
}
