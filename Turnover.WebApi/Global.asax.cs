﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Turnover.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            DiContainerConfig.Initialize();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
