using Microsoft.AspNetCore.Mvc;

namespace TripLink.Controllers
{
    public class DashboardController : MyBaseController
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
