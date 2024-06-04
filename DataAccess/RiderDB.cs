using BusinessInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RiderDB : IRiderDB
    {
        DataTable dt = new DataTable();
        #region "Variable and constructor"
        public static string connection;
        //int totalItemCount = 0;

        static RiderDB()
        {
            connection = SingleConnection.Connect();
        }

        #endregion

        public int GetTestValue()
        {
            string aa = connection;
            return 0;
        }
    }
}
