using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.Model
{
    class TaxCalculator
    {
        LogType log;

        public TaxCalculator(LogType log)
        {
            this.log = log;
        }

        public int CalculateTax(int amount, int rate)
        {
            try 
            {
                int result = amount / rate;
                return result;
            }
            catch(Exception e)
            {
                if(log.Equals(LogType.JSON))
                {
                    new JSONLogger().Log("Don't Divide by 0");
                }
                else if (log.Equals(LogType.XML))
                {
                    new TxtLogger().Log("Don't Divide by 0");
                }
                else if (log.Equals(LogType.JSON))
                {
                    new JSONLogger().Log("Don't Divide by 0");
                }
                return -1;   
            }
        }
    }
}
