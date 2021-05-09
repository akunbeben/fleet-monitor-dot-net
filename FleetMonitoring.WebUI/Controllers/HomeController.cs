using System.Web.Mvc;

namespace FleetMonitoring.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}