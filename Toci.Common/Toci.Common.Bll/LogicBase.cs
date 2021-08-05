using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Toci.Common.Bll.Interfaces;
using Toci.Common.Database;
using Toci.Common.Database.Interfaces;

namespace Toci.Common.Bll
{
    public abstract class LogicBase<TModel> : ILogicBase<TModel> where TModel : class
    {
        protected abstract DbContext GetEfHandle();

        public virtual TModel Insert(TModel model)
        {
            IDbHandle<TModel> DbHandle = new DbHandle<TModel>(GetEfHandle);

            return DbHandle.Insert(model);
        }

        public virtual IQueryable<TModel> Select(Expression<Func<TModel, bool>> filter)
        {
            IDbHandle<TModel> DbHandle = new DbHandle<TModel>(GetEfHandle);
            
            return DbHandle.Select().Where(filter).AsQueryable();
        }

        public virtual bool Update(TModel model)
        {
            IDbHandle<TModel> DbHandle = new DbHandle<TModel>(GetEfHandle);

            return DbHandle.Update(model);
        }

        public virtual int Delete(TModel model)
        {
            IDbHandle<TModel> DbHandle = new DbHandle<TModel>(GetEfHandle);

            return DbHandle.Delete(model);
        }
    }
}
