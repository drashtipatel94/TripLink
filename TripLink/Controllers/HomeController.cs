using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripLink.Models;

namespace TripLink.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;
        private IConfiguration Configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }
        private string GetConnectionString()
        {
            return this.Configuration.GetConnectionString("TripLinkDb");
        }*/

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}