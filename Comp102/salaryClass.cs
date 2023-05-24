using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class salaryClass
    {
        public void salaryMeth()
        {
            string name;
            int Salary;
            Console.Write("Enter Name:");
            name = Console.ReadLine();
            Console.Write("Enter Monthly Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
            if (Salary < 15000)
            {
                int b = ((int)(Salary
                * 0.25));
                Console.Write("Mr/Ms " + name + ",your corresponding bonus is: " + b);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Mr/Ms " + name + ", your corresponding bonus is 5,000");
            }
            Console.ReadLine();
        }
    }
}
