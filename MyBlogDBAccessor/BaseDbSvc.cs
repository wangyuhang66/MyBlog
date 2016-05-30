using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using MySql.Data.MySqlClient;

namespace MyBlogDBAccessor
{
   public class BaseDbSvc
    {
        public BaseDbSvc()
        {

        }

        public BaseDbSvc(MySqlConnection connection)
        {
            DbConnection = connection;
        }

        protected MySqlConnection DbConnection = null;
        protected const string GeneralTableIdField = "Id";

        internal MySqlConnection EnsureMyBlogConnection()
        {
            if (DbConnection == null)
            {
                DbConnection = DBConnectionMgr.GetMyBlogConnection();
                return DbConnection;
            }
            else return null;
        }


    }
}
