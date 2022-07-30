using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Common.Bll.Errors
{
    public abstract class ReturnedResponse<TResult>
    {
        public TResult MethodResult { get; set; }

        public string ErrorMessage { get; set; }
        public bool IsSuccess { get; set; }
    }
}
