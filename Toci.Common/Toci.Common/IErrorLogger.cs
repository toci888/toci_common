﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Common
{
    public interface IErrorLogger
    {
        void Log(List<Exception> ex);
    }
}
