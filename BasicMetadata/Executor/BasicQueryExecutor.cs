using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

using BasicQuerying.Utils;
using BasicQuerying.Models;

namespace BasicQuerying.Executor
{
    class BasicQueryExecutor
    {
        public static string executeQuery(string queryAsString)
        {
            string jsonResponseOfQueryExecution = "";

            OleDbConnection connection = null;
            ResultRecords results = new ResultRecords(queryAsString);

            try
            {
                connection = ConnectionUtil.getDBConnection();

                OleDbCommand command = new OleDbCommand(queryAsString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                jsonResponseOfQueryExecution = convertResultSetToResultJson(reader, results);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                results.isQueryError = true;
                results.errorException = ex.GetBaseException().ToString();
                jsonResponseOfQueryExecution = JsonUtil.convertObjectToJson(results);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return jsonResponseOfQueryExecution;
        }

        private static string convertResultSetToResultJson (OleDbDataReader reader, ResultRecords results) {
            string jsonResponseOfQueryExecution = "";
            
            int i=0;
            while (reader.Read())
            {
                Dictionary<string, string> recordAtHand = new Dictionary<string,string>();
                i++;
                for (int j=0; j<reader.FieldCount; j++) {
                    recordAtHand.Add(reader.GetName(j).ToString(), reader.GetValue(j).ToString());
                }
                results.records.Add(i, recordAtHand);
            }
            results.numberOfRecords = i;
            reader.Close();
            jsonResponseOfQueryExecution = JsonUtil.convertObjectToJson(results);
            return jsonResponseOfQueryExecution;
        }
    }
}
