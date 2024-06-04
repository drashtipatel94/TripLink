using BusinessInterface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripLink.Models;

namespace TripLink.Controllers
{
    public class MyBaseController : Controller
    {
        #region "Interface Initialization"

        #region "ItemProcSvr"
        private static IRiderDB _riderDB;
        public static IRiderDB objRiderDB
        {
            get
            {
                if (_riderDB == null)
                    throw new ApplicationException("MyBaseController.CustomerDB: CustomerDB is null.");
                return _riderDB;
            }
            set { _riderDB = value; }
        }
        #endregion


        #endregion
    }
}
