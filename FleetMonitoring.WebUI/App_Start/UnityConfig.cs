using FleetMonitoring.Data.Repositories;
using FleetMonitoring.WebUI.Controllers;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace FleetMonitoring.WebUI.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IOwnerRepository, OwnerRepository>();
            container.RegisterType<IUnitRepository, UnitRepository>();
            container.RegisterType<AccountController>(new InjectionConstructor());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}