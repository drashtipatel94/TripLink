using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class SingleConnection
    {
        private SingleConnection() { }
        public static string Connect()
        {

            //string conStr = configuration.GetSection("MySettings").GetSection("DbConnection").Value;
                //Convert.ToString(ConfigurationManager.AppSettings["TripLinkDb"]);
            //string conStr = "Server=localhost;Database=TripLink;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true";
            /*string connStr = string.Concat(ConfigurationManager.ConnectionStrings[WebConfigSettings.Local]);
            int DatabaseLive = Convert.ToInt32(ConfigurationManager.AppSettings[WebConfigSettings.DatabaseLive]);

            switch (DatabaseLive)
            {
                case 1:
                    connStr = string.Concat(ConfigurationManager.AppSettings[WebConfigSettings.Local]);
                    break;
                case 2:
                    connStr = string.Concat(ConfigurationManager.AppSettings[WebConfigSettings.Staging]);
                    break;
                case 3:
                    connStr = string.Concat(ConfigurationManager.AppSettings[WebConfigSettings.Production]);
                    break;
                default:
                    connStr = string.Concat(ConfigurationManager.AppSettings[WebConfigSettings.Local]);
                    break;
            }*/
            return "";
        }
    }
}
