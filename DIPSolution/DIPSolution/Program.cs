using DIPSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(new JSONLogger());

            Console.WriteLine(calc.CalculatorTax(10,5));
            Console.WriteLine(calc.CalculatorTax(0, 0));
        }
    }
}
