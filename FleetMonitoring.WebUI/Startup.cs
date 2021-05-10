using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FleetMonitoring.WebUI.Startup))]
namespace FleetMonitoring.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}