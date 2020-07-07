﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ErrorLogEntity
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string ControllerName { get; set; }
        public string UserAgent { get; set; }
        public string StackTrace { get; set; }
        public string SessionId { get; set; }
        public string TargetedResult { get; set; }
        public string TimeStamp { get; set; }

    }
}
