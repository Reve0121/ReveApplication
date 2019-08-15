using AutoMapper;
using ReveMDMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ReveApplication
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<CustomerMapProfile>();
            });
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
