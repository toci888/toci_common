using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Toci.Common.Microservices.Interfaces
{
    public interface IApiControllerBase<TLogic, TModel>
    {
        public TModel Create(TModel model);
        public IEnumerable<TModel> Get();
        public TModel Update(TModel model);
        public int Delete(TModel model);
    }
}
