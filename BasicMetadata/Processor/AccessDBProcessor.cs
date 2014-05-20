using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Access;

namespace BasicQuerying.Processor
{
    class AccessDBProcessor
    {
        public static void fillup() {
                        Microsoft.Office.Interop.Access.Application app = null;
            app = new Application();
            app.OpenCurrentDatabase("c:\\play\\WithAll.accdb", false);
            var obj = app.CurrentData;
            foreach (AccessObject obj1 in app.CurrentData.AllTables)
            {
                if (true)
                {
                    Console.WriteLine(obj1.FullName);
                    Console.WriteLine(obj1.Type);
                }

            }

            foreach (AccessObject obj1 in app.CurrentData.AllQueries)
            {
                if (true)
                {
                    Console.WriteLine(obj1.FullName);
                    Console.WriteLine(obj1.Type);
                }

            }
      
            
            Console.ReadLine();
        }
    }
}
