using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyBlogDBAccessor;

namespace MyBlogFacade
{
   public class InitReferenceEnv
    {
        private static bool EnvInitialized = false;

        public static void InitSubAssembliesEnv(string staticConn)
        {
            if (!EnvInitialized)
            {
                DBConnectionMgr.MyBlogConnectionString = staticConn;
                EnvInitialized = true;
            }
        }

    }
}
