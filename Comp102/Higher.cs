using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class Higher
    {
        public void HigherMeth()
        {
            int a, b;
            Console.Write("Enter Number A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number B: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Number A is HIGHER than Number B");
            }
            else
            {
                Console.WriteLine("Number B is HIGHER than Number A");
            }
        }
    }
}
