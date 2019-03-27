using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData;
using Microsoft.Restier.Publishers.OData.Batch;
using Nexus_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Nexus_WebApplication {

    public static class WebApiConfig
    {
        public async static void Register(HttpConfiguration config)
        {
            // enable query options for all properties
            //config.Filter().Expand().Select().OrderBy().MaxTop(null).Count();
            
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            await config.MapRestierRoute<EntityFrameworkApi<NexusContext>>(
                "odata",
                "odata",
                new RestierBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }

}
