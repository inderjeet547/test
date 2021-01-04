using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Model
{
    class JSONLogger : ILog
    {
        public void log(string ErrorMessage)
        {
            Console.WriteLine("Writing Data in JSON File...\n" + ErrorMessage);
        }
    }
}
