using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;

namespace NopWebApi.CustomConfig
{
    public static class ConfigurationWeb
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.MapHttpAttributeRoutes();
            configuration.Routes.MapHttpRoute("Default", "api/{controller}/{id}",new {id=RouteParameter.Optional });
            HttpRoute httpRoute = new HttpRoute("api/{controller}/{id}", new HttpRouteValueDictionary(new { id = RouteParameter.Optional }));
            configuration.Routes.Add("second",httpRoute);
            JsonMediaTypeFormatter jsonMediaType = configuration.Formatters.JsonFormatter;
            jsonMediaType.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}