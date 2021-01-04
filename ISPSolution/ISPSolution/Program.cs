using ISPSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorkEat m = new Managers();
            IWork r = new Robots();

            PrintManagersInfo(m);
            PrintRobotsInfo(r);
        }

        public static void PrintManagersInfo(IWorkEat m)
        {
            m.startWork();
            m.stopWork();
            m.startEat();
            m.stopEat();
        }

        public static void PrintRobotsInfo(IWork r)
        {
            r.startWork();
            r.stopWork();
        }
    }
}
