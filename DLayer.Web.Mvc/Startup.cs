﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DLayer.Web.Mvc.Startup))]
namespace DLayer.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
