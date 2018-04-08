using System.Web.Mvc;

namespace www.Controllers
{
    public class WebController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View();
        }
    }
}