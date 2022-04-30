﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Common.Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }

        public DateTime Begining { get; set; }

        public DateTime Ending { get; set; }

        public int StartHour { get { return Begining.Hour; } }

        public int EndHour { get { return Ending.Hour; } }

        public int StartMinute { get { return Begining.Minute; } }

        public int EndMinute { get { return Ending.Minute; } }
    }
}
