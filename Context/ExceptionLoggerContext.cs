using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class ExceptionLoggerContext
    {
        public ExceptionContext ExceptionContext { get; set; }
        public bool CanBeHandled { get; set; }
    }
}
