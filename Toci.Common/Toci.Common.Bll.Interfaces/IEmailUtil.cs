using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Common.Bll.Interfaces
{
    public interface IEmailUtil
    {
        bool SendEmail(EmailContent content);
    }
}
