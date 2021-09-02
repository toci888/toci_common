using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Toci.Common.Bll.Interfaces;
using Toci.Common.Microservices.Interfaces;

namespace Toci.Common.Microservices
{
    public abstract class ApiControllerBase<TLogic, TModel> : ControllerBase, IApiControllerBase<TLogic, TModel> where TLogic : ILogicBase<TModel> where TModel : class
    {
        protected TLogic Logic;
        protected ApiControllerBase(TLogic logic)
        {
            Logic = logic;
        }

        [HttpPost]
        public virtual TModel Create(TModel model)
        {
            return Logic.Insert(model);
        }

        [HttpGet]
        public virtual IEnumerable<TModel> Get()
        {
            return Logic.Select(m => true);
        }

        [HttpPut]
        public virtual TModel Update(TModel model)
        {
            return Logic.Update(model);
        }

        [HttpDelete]
        public virtual int Delete(TModel model)
        {
            return Logic.Delete(model);
        }
    }
}