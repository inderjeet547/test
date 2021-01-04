using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.Model
{
    class TxtLogger
    {
        public void Log(String ErrorMessage)
        {
            Console.WriteLine("Writing Data in Txt File...\n" + ErrorMessage);
        }
    }
}
