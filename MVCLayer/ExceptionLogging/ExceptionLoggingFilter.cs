using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace MVCLayer.ExceptionLogging
{
    public class ExceptionLoggingFilter : ExceptionFilterAttribute
    {

        ILoggerService loggerService = new LoggerService();
        public override void OnException(HttpActionExecutedContext filterContext)
        {
            loggerService.CreateNotePadLog(ConvertToLoggerEntity(filterContext));
            base.OnException(GetJsonResult(filterContext));
        }

        public ErrorLogEntity ConvertToLoggerEntity (HttpActionExecutedContext filterContext)
        {

            var errorLogEntity = new ErrorLogEntity()
            {
                ControllerName = filterContext.Request.RequestUri.LocalPath,
                StackTrace = filterContext.Exception.StackTrace,
                TimeStamp = DateTime.Now.ToString()
            };
            return errorLogEntity;
        }

        private HttpActionExecutedContext GetJsonResult(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response = new HttpResponseMessage()
            {
                Content = new StringContent("An error has occured. Please try again later", System.Text.Encoding.UTF8, "text/plain"),
                StatusCode = HttpStatusCode.NotImplemented
            };
            return actionExecutedContext;
        }
    }
}