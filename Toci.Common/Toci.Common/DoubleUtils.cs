using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Common
{
    public static class DoubleUtils
    {
        public static double RoundDouble(double val, int places)
        {
            return Math.Round(val, places);
        }
    }
}
