using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Http;

using BasicQuerying.Processor;
using BasicQuerying.Executor;

namespace BasicQuerying.Controller
{
    public class AccessController : ApiController 
    {
        public string GetExecuteQuery(string query)
        {
            return BasicQueryExecutor.executeQuery(query);
        }

        public string Get()
        {
            Console.WriteLine("Hello World!");
            return "Hello World!";
        }
    }
}
