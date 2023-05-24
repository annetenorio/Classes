using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class nicknameClass
    {
        public void nicknameMeth()
        {
            string[] thesis = new string[10] { "thea", "otin", "daz", "ham", "kyle", "jia", "anne", "mark", "kath", "sefd"};

            Console.WriteLine("Using For Loop, my friends' nicknames are: ");
            for (int a = 0; a <= 9; a++)
            {
                Console.Write(thesis[a] + " ");


            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Using While Loop, my friends' nicknames are: ");
            int b = 0;
            while (b <= 9)
            {
                Console.Write(thesis[b] + " ");
                b++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Using Do-While Loop, my friends' nicknames are: ");
            int c = 0;
            do
            {
                Console.Write(thesis[c] + " ");
                c++;
            }
            while (c <= 9);
            Console.ReadKey();
        }
    }
}
