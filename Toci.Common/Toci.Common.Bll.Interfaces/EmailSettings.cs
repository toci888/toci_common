using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Common.Bll.Interfaces
{
    public class EmailSettings
    {
        public string AdminLoginAddress { get; set; }
        public string AdminPassword { get; set; }
        public string SmtpAddress { get; set; }
        public int Port { get; set; }
    }
}
