﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Toci.Common.Database.Interfaces;

namespace Toci.Common.Database
{
    public class DbHandle<TModel> : IDbHandle<TModel> where TModel : class
    {
        protected DbContext DatabaseHandle;

        public DbHandle(Func<DbContext> databaseHandle)
        {
            DatabaseHandle = databaseHandle();
        }

        public int Delete(TModel model)
        {
            DatabaseHandle.Remove(model);

            DatabaseHandle.SaveChangesAsync();

           // DatabaseHandle?.Dispose();

            return 1;
        }

        public TModel Insert(TModel model)
        {
            // insert into product (id, ....)
            EntityEntry entr = DatabaseHandle.Set<TModel>().Add(model);

            DatabaseHandle.SaveChanges();

           // DatabaseHandle?.Dispose();

            return (TModel)(entr.Entity);
        }

        public IQueryable<TModel> Select()
        {
            IQueryable<TModel> result = DatabaseHandle.Set<TModel>().AsQueryable().AsNoTracking();

            //DatabaseHandle.Dispose();

            return result;
        }

        public TModel Update(TModel model)
        {
            DatabaseHandle.Update(model);

            DatabaseHandle.SaveChangesAsync();

          //  DatabaseHandle?.Dispose();

            return model;
        }

        public void Dispose()
        {
            DatabaseHandle?.Dispose();
        }
    }
}
