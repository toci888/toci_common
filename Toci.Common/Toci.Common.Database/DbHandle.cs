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

            return 1;
        }

        public TModel Insert(TModel model)
        {
            EntityEntry entr = DatabaseHandle.Set<TModel>().Add(model);

            DatabaseHandle.SaveChanges();

            return (TModel)(entr.Entity);
        }

        public IQueryable<TModel> Select()
        {
            return DatabaseHandle.Set<TModel>().AsQueryable();
        }

        public TModel Update(TModel model)
        {
            DatabaseHandle.Update(model);

            DatabaseHandle.SaveChangesAsync();

            return model;
        }

        public void Dispose()
        {
            DatabaseHandle?.Dispose();
        }
    }
}
