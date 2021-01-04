using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.Model
{
    class XmlLogger
    {
        public void Log(String ErrorMessage)
        {
            Console.WriteLine("Writing Data in XML File...\n" + ErrorMessage);
        }
    }
}
