using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class stringfuncClass
    {
        public void stringfuncMeth()
        {
            int opt, index;
            string input, check;

            while (true)
            {
                Console.WriteLine("1. Clone");
                Console.WriteLine("2. Length");
                Console.WriteLine("3. String Upper");
                Console.WriteLine("4. String Lower");
                Console.WriteLine("5. Trim");
                Console.WriteLine("6. Contains");
                Console.WriteLine("7. ToCharArray");
                Console.WriteLine("8. Substring");
                Console.WriteLine("9. StartsWith");
                Console.WriteLine("10. Split");
                Console.WriteLine("11. EndsWith");
                Console.WriteLine("12. IndexOf");
                Console.WriteLine("13. LastIndexOf");
                Console.WriteLine("14. GetHashCode");
                Console.WriteLine("15. Reverse");
                Console.WriteLine("16. Replace");
                Console.WriteLine();
                Console.Write("Select a number from 1-16: ");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine(input.Clone());
                        break;
                    case 2:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine("The length of the string youe entered is " + input.Length);
                break;
                    case 3:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine(input.ToUpper());
                        break;
                    case 4:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine(input.ToLower());
                        break;
                    case 5:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine(input.Trim());
                        break;
                    case 6:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Check contains: ");
                        check = Console.ReadLine();
                        if (input.Contains(check))
                        {
                            Console.WriteLine("The string contains " + check);
                        }
                        else
                        {
                            Console.WriteLine("The string does not contain " +
                           check);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        char[] chars = input.ToCharArray();
                        for (int i = 0; i < chars.Length; i++)
                            Console.Write(" " + chars[i]); ;
                        break;
                    case 8:
                        Console.WriteLine("[Display the first 5 letters of your string]");
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine(input.Substring(0, 5));
                        break;
                    case 9:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Check if it Starts With: ");
                        check = Console.ReadLine();

                        if (input.StartsWith(check))
                        {
                            Console.WriteLine("The string starts with: " + check);
                        }
                        else
                        {
                            Console.WriteLine("The string does not start with " +
                           check);
                        }
                        break;
                    case 10:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        string[] arr = input.Split();
                        foreach (String str in arr)
                        {
                            Console.Write(str + ", ");
                        }
                        break;
                    case 11:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Check if it Ends With: ");
                        check = Console.ReadLine();
                        if (input.EndsWith(check))
                        {
                            Console.WriteLine("The string ends with: " + check);
                        }
                        else
                        {
                            Console.WriteLine("The string does not end with " +
                           check);
                        }
                        break;
                    case 12:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Display the Index Value of: ");
                        check = Console.ReadLine();
                        index = input.IndexOf(check);
                        Console.WriteLine("The Index Value of " + check + " is " +
                        index);
                        break;
                    case 13:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Display the Index Value of: ");
                        check = Console.ReadLine();
                        index = input.LastIndexOf(check, 6);
                        Console.WriteLine("The Last Index Value of " + check + " is " + index);
                        break;
                    case 14:
                        Console.WriteLine("Enter a String : ");
                        input = Console.ReadLine();
                        Console.WriteLine("The HashCode of " + input + " is " +
                        input.GetHashCode());
                        break;
                    case 15:
                        Console.Write("Enter a String : ");
                        input = Console.ReadLine();
                        char[] reverse = input.ToCharArray();
                        Array.Reverse(reverse);
                        Console.WriteLine(new string(reverse));
                        break;
                    case 16:
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Replace inputted string with: ");
                        check = Console.ReadLine();
                        Console.WriteLine(input.Replace(input, check));
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

            }
        }
    } 
}
