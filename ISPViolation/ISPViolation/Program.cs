using ISPViolation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorkable m = new Managers();
            IWorkable r = new Robots();

            IWorkable[] arr1 = new IWorkable[2];

            arr1[0] = m;
            arr1[1] = r;

            PrintInfo(arr1);
        }

        public static void PrintInfo(IWorkable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                IWorkable a = array[i];
                a.startWork();
                a.stopWork();
                a.startEat();
                a.stopEat();
            }
        }

    }
}
