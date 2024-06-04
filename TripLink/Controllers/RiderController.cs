using Microsoft.AspNetCore.Mvc;
using System;

namespace TripLink.Controllers
{
    public class RiderController : MyBaseController
    {
        private readonly IConfiguration _config;
        private readonly String conn;
        public RiderController(IConfiguration config)
        {
            _config = config;
            conn = _config.GetSection("MySettings").GetSection("DbConnection").Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterRider(bool isForRider = true)
        {
            //int aaa = objRiderDB.GetTestValue();
            return View();
        }
    }
}
