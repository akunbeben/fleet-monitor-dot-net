using FleetMonitoring.Data.Repositories;
using System.Web.Mvc;
using Unity;
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

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}