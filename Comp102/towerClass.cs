using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class towerClass
    {
        public void towerMeth()
        {
            double n, moves;
            //char ans;

            Console.WriteLine("Enter the numberof disks: ");

            n = Convert.ToDouble(Console.ReadLine());
            moves = Math.Pow(2, n) - 1;
            Console.WriteLine("The minimum number of moves is " + moves);
        }
    }
}
