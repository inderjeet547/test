using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolution.Model
{
    interface IWorkEat
    {
        void startWork();
        void stopWork();
        void startEat();
        void stopEat();
    }
}
