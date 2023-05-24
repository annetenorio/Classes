using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class Program
    {
        static void Main(string[] args)
        {
       
        here:
            Console.Clear();
            Console.WriteLine("Compilation of Laboratory Activities in DSA");
            Console.WriteLine("Compiled by: Anne Tenorio");
            Console.WriteLine("DSA Wed 7:00 - 10:00");
            Console.WriteLine("Presented to: Dr. Leonard L. Alejandro");
            Console.WriteLine("");

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Choose from the following menu: ");
            Console.WriteLine("1 - Temperature to Celcius                7 - Classmate's Nickname (Array)");
            Console.WriteLine("2 - Higher than                           8 - String Functions");
            Console.WriteLine("3 - Salary                                9 - Stack");
            Console.WriteLine("4 - Tower of Hanoi                       10 - Linked List (Add)");
            Console.WriteLine("5 - Fibonacci Sequence                   11 - Midterm Grade Computation");
            Console.WriteLine("6 - Surname: TENORIO (Array)             12 - Sorting");

            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (choice)
            {
                case 1:
                    tempcelClass a = new tempcelClass();
                    a.tempcelMeth();
                    break;

                case 2:
                    Higher b = new Higher();
                    b.HigherMeth();
                    break;

                case 3:
                    salaryClass c = new salaryClass();
                    c.salaryMeth();
                    break;

                case 4:
                    towerClass d = new towerClass();
                    d.towerMeth();
                    break;

                case 5:
                    fibonacciClass e = new fibonacciClass();
                    e.fibonacciMeth();
                    break;

                case 6:
                    surnameClass f = new surnameClass();
                    f.surnameMeth();
                    break;

                case 7:
                    nicknameClass g = new nicknameClass();
                    g.nicknameMeth();
                    break;

                case 8:
                    stringfuncClass h = new stringfuncClass();
                    h.stringfuncMeth();
                    break;

                case 9:
                    stackClass i = new stackClass();
                    i.stackMeth();
                    break;

                case 10:
                    linkedClass j = new linkedClass();
                    j.linkedMeth();
                    break;

                case 11:
                    midtermGrades k = new midtermGrades();
                    k.midtermMeth();
                    break;

                case 12:
                    sortingClass l = new sortingClass();
                    l.sortingMeth();
                    break;

                default:
                    Console.WriteLine("Invalid user entry!");
                    break;
            }

            Console.WriteLine("Do you want to try again? [Y/N]: ");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                goto here;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
