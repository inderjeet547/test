using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolution.Model
{
    class Robots : IWork
    {
        public void startWork()
        {
            Console.WriteLine("Robots started Working");
        }

        public void stopWork()
        {
            Console.WriteLine("Robots stopped Working");
        }
    }
}
