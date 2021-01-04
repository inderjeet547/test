using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation.Model
{
    class Robots : IWorkable
    {
        public void startWork()
        {
            Console.WriteLine("Robots started Working");
        }
        public void stopWork()
        {
            Console.WriteLine("Robots stopped Working");
        }
        public void startEat()
        {
            Console.WriteLine("Robots started Eating");
        }
        public void stopEat()
        {
            Console.WriteLine("Robots stopped Eating");
        }
    }
}
