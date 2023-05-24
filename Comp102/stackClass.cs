using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Comp102
{
    public class stackClass
    {
        public void stackMeth()
        {
            string menu;
            int a, b;
            Stack<int> stack = new Stack<int>();
            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("STACK OPERATIONS MENU");
               
                Console.WriteLine("A - Push");
                Console.WriteLine("B - Pop");
                Console.WriteLine("C - Count");
                Console.WriteLine("D - Display");
                Console.WriteLine("E - Exit");
                Console.WriteLine("F - Peak");

            start:
                Console.WriteLine();
                Console.Write("Enter Stack Operation: ");
               
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "A":
                    case "a":
                        Console.Write("How many elements do you want to add ? ");
                       
                        a = Convert.ToInt32(Console.ReadLine());
                        for (int z = 1; z <= a;z++)
                        {
                            Console.Write("Enter element: ");
                            int x =Convert.ToInt32(Console.ReadLine());
                            stack.Push(x);
                        }

                        goto start;

                    case "B":
                    case "b":
                        Console.Write("How many elements you want to remove ? ");
                       
                        b =Convert.ToInt32(Console.ReadLine());
                        for (int z = 1; z <= b; z++)
                        {
                            stack.Pop();
                        }
                        goto start;

                    case "C":
                    case "c":
                        Console.WriteLine("The total number of elements in the stack is " + stack.Count());
                        Console.WriteLine();
                        goto start;

                    case "D":
                    case "d":
                        if (menu.Contains("B"))
                        {
                            Console.WriteLine("The elements in the stack after POP are: ");
                        foreach (var x1 in stack)
                            {
                                Console.WriteLine(x1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The elements in the stack are: ");
                         foreach (var x in stack)
                            {
                                Console.WriteLine(x);
                            }
                        }
                        goto start;

                    case "E":
                    case "e":
                        Environment.Exit(0);
                        goto start;

                    case "F":
                    case "f":
                        Console.WriteLine("The topmost element in the stack is " + stack.Peek());
                        goto start;

                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
