﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamSample2.Startup))]
namespace ExamSample2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
