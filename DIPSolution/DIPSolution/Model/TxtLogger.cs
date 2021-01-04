using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Model
{
    class TxtLogger : ILog
    {
        public void log(string ErrorMessage)
        {
            Console.WriteLine("Writing Data in Txt File...\n" + ErrorMessage);
        }
    }
}
