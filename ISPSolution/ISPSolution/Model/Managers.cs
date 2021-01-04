using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolution.Model
{
    class Managers : IWorkEat
    {
        public void startEat()
        {
            Console.WriteLine("Managers started Eating");
        }

        public void startWork()
        {
            Console.WriteLine("Managers started Working");
        }

        public void stopEat()
        {
            Console.WriteLine("Managers stopped Eating");
        }

        public void stopWork()
        {
            Console.WriteLine("Managers stopped Working");
        }
    }
}
