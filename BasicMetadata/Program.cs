using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Access;
using BasicQuerying.Utils;
using BasicQuerying.Modes;

namespace BasicQuerying
{
    class Program
    {
        static void Main(string[] args)
        {
            string accessFileName = "";
            if (args.Length > 1 && args[0] != null)
            {
                accessFileName = args[0];
            }
            else
            {
                accessFileName = PropertyUtil.getAccessFileNameFromPropertyFile();
            }

            PropertyUtil.accessFileName = accessFileName;
            ServerMode.startServer();
        }
    }
}
