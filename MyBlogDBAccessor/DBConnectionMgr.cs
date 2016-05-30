using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace MyBlogDBAccessor
{
   public class DBConnectionMgr
    {
       public static string MyBlogConnectionString = string.Empty;

       public static MySqlConnection GetMyBlogConnection()
        {
            MySqlConnection mysqlConn = new MySqlConnection(MyBlogConnectionString);
            mysqlConn.Open();
            return mysqlConn;
        }

    }
}
