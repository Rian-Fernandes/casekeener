using Microsoft.AspNetCore.Mvc;

namespace casekeener.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}