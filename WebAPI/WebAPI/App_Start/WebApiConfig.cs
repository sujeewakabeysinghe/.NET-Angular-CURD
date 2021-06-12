using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using System.Net.Http; //to convert xml to json
using System.Net.Http.Headers; //to convert xml to json

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html")); //to convert xml to json
        }
    }
}
