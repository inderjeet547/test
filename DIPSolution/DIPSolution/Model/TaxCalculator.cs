using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Model
{
    class TaxCalculator
    {
        ILog log;

        public TaxCalculator(ILog log)
        {
            this.log = log;
        }

        public int CalculatorTax(int amount, int rate)
        {
            int result;
            try
            {
                result = amount / rate;
            }
            catch(Exception ex)
            {
                log.log(ex.ToString());
                return -1;
            }
            return result;
        }
    }
}
