using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;
using Context;

namespace MVCLayer.GlobalExeptionHandling
{
    public class LoggerHandler : ExceptionLogger
    {

        public virtual Task HandleAsync(System.Web.Http.ExceptionHandling.ExceptionHandlerContext context,
                                        CancellationToken cancellationToken)
        {
            if (!ShouldHandle(context))
            {
                return Task.FromResult(0);
            }

            return HandleAsyncCore(context, cancellationToken);
        }

        public virtual Task HandleAsyncCore(System.Web.Http.ExceptionHandling.ExceptionHandlerContext context,
                                           CancellationToken cancellationToken)
        {
            HandleCore(context);
            return Task.FromResult(0);
        }

        public virtual void HandleCore(System.Web.Http.ExceptionHandling.ExceptionHandlerContext context)
        {
        }

        public virtual bool ShouldHandle(System.Web.Http.ExceptionHandling.ExceptionHandlerContext context)
        {
            return context.ExceptionContext.CatchBlock.IsTopLevel;
        }
    }
}