﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HookReceivers.Tests
{
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Initialize Generic JSON WebHook receiver
            config.InitializeReceiveGenericJsonWebHooks();
        }
    }
}
