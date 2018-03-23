using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DBDAL
{
    public static class ConfiguracionDAL
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        public static string ConStr
        {
            get { return conStr; }
        }
    }
}
