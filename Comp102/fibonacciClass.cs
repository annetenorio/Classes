using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class fibonacciClass
    {
        public void fibonacciMeth()
        {
            double n, rem, value;
            
            Console.WriteLine("Enter the value of n: ");
           
            n =Convert.ToDouble(Console.ReadLine());
            rem = n % 2;
            if (rem == 0)
            {
                value = (Math.Pow(1.618, n) +
               Math.Pow(1.168, -n)) / 2.236;
            }
            else
            {
                value = (Math.Pow(1.618, n)
               - Math.Pow(1.168, -n)) / 2.236;
            }
            Console.WriteLine("Fibonacci number at " + n + "th position: " + value);

        }
    }
}
