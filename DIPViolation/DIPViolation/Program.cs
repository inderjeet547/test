using DIPViolation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(LogType.JSON);

            Console.WriteLine(calc.CalculateTax(10,5));
            Console.WriteLine(calc.CalculateTax(0,0));
        }
    }
}
