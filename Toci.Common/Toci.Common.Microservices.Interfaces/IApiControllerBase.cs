using System;
using System.Linq;
using System.Linq.Expressions;

namespace Toci.Common.Microservices.Interfaces
{
    public interface IApiControllerBase<TLogic, TModel>
    {
        public TModel Create(TModel model);
        public IQueryable<TModel> Get();
        public bool Update(TModel model);
        public int Delete(TModel model);
    }
}
