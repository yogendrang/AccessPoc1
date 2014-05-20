using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace BasicQuerying.Utils
{
    class ConnectionUtil
    {
        private static OleDbConnection _connection = null;

        public static OleDbConnection getDBConnection()
        {
            if (_connection != null)
            {
                return _connection;
            }
            else
            {
                _connection = new OleDbConnection(PropertyUtil.connectionString);
            }

            return _connection;
        }
    }
}
