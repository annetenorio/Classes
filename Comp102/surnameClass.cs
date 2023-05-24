using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class surnameClass
    {
        public void surnameMeth()
        {
            char[] surname = new char[7] { 'T', 'E', 'N', 'O', 'R', 'I', 'O' };
            Console.WriteLine("Using manual referencing, the letters from my surname are: ");
           
            Console.Write(surname[0] + " ");
            Console.Write(surname[1] + " ");
            Console.Write(surname[2] + " ");
            Console.Write(surname[3] + " ");
            Console.Write(surname[4] + " ");
            Console.Write(surname[5] + " ");
            Console.Write(surname[6] + " ");
            Console.ReadKey();

        }
    }
}
