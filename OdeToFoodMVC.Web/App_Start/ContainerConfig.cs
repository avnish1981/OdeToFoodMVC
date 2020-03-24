using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OdeToFoodMVC.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpconfiguation)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<clsInMemoryData>()
                .As<IRestaurantData>()
                .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpconfiguation.DependencyResolver = new AutofacWebApiDependencyResolver(container);



        }
    }
}