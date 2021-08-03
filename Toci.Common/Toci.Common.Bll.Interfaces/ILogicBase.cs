using System;
using System.Linq;
using System.Linq.Expressions;

namespace Toci.Common.Bll.Interfaces
{
    public interface ILogicBase<TModel> where TModel : class
    {
        IQueryable<TModel> Select(Expression<Func<TModel, bool>> filter);

        TModel Insert(TModel model);

        bool Update(TModel model);

        int Delete(TModel model);
    }
}
