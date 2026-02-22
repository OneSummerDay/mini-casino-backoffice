using Microsoft.AspNetCore.Mvc;

namespace MiniCasino.Backoffice.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("MiniCasino Backoffice is running ✅");
        }
    }
}