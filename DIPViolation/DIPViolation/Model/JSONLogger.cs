using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.Model
{
    class JSONLogger
    {
        public void Log(String ErrorMessage)
        {
            Console.WriteLine("Writing Data in JSON File...\n" + ErrorMessage);
        }
    }
}
