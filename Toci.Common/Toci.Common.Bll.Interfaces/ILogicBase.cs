using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Toci.Common.Bll.Interfaces
{
    public interface ILogicBase<TModel> where TModel : class
    {
        IEnumerable<TModel> Select(Expression<Func<TModel, bool>> filter);

        TModel Insert(TModel model);

        TModel Update(TModel model);

        int Delete(TModel model);
    }
}
