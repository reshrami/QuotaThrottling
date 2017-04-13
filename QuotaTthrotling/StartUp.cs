﻿using Owin;
using QuotaTthrotling.Tthrottling;
using System.Web.Http;

namespace QuotaTthrotling
{
    public class Startup
    {
        // This method is required by Katana:
        public void Configuration(IAppBuilder app)
        {
            var webApiConfiguration = ConfigureWebApi();
            app.Use<Tthrottling.CheckTthrottling>(new TthrottlingConfigurationOptions(""));
            // Use the extension method provided by the WebApi.Owin library:
            app.UseWebApi(webApiConfiguration);
           
        }


        private HttpConfiguration ConfigureWebApi()
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            return config;
        }       
    }
}
