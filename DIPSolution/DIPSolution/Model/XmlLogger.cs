using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Model
{
    class XmlLogger : ILog
    {
        public void log(string ErrorMessage)
        {
            Console.WriteLine("Writing Data in XML File...\n" + ErrorMessage);
        }
    }
}
