using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation.Model
{
    class Managers : IWorkable
    {
        public void startWork()
        {
            Console.WriteLine("Manager started Working");
        }
        public void stopWork()
        {
            Console.WriteLine("Manager stopped Working");
        }
        public void startEat()
        {
            Console.WriteLine("Manager started Eating");
        }
        public void stopEat()
        {
            Console.WriteLine("Manager stopped Eating");
        }
    }
}
