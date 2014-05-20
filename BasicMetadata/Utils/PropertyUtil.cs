using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace BasicQuerying.Utils
{
    class PropertyUtil
    {
        public static string _accessFileName;

        public static string accessFileName
        {
            get { return _accessFileName; }
            set { 
                _accessFileName = value;
                PropertyUtil.connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                    PropertyUtil.accessFileName + "";
            }
        }

        public static string _connectionString;

        public static string connectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public static string getAccessFileNameFromPropertyFile()
        {
            return ConfigurationManager.AppSettings["accessFilePath"];
        }

    }
}
