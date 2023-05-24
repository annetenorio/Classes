using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class tempcelClass
    {
       public void tempcelMeth()
        {
            Console.Write("Enter Temperature in Fahrenheit: ");
            float f = float.Parse(Console.ReadLine());
            float c = (float)((5.0 / 9.0) * (f - 32));
            Console.WriteLine("Equivalent Temperature in Celcsius: " + c);
            Console.ReadLine();
        }
    }
}
