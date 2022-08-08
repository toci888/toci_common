using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Common.Microservices
{
    public abstract class ApiSimpleControllerBase<TLogic> : ControllerBase
    {
        protected TLogic Logic;
        protected ApiSimpleControllerBase(TLogic logic)
        {
            Logic = logic;
        }
    }
}
