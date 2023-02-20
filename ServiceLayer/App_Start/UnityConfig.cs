using BuisnessLayer.APIRepo;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace ServiceLayer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IGetData, GetData>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            //  DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}