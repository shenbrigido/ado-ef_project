using MVCLayer.ExceptionLogging;
using System.Web.Http;

namespace MVCLayer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Filters.Add(new ExceptionLoggingFilter());
        }
    }
}

