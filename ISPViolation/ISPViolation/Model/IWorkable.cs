using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation.Model
{
    interface IWorkable
    {
        void startWork();
        void stopWork();
        void startEat();
        void stopEat();
    }
}
