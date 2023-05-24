using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class linkedClass
    {
        public void linkedMeth()
        {
            LinkedList<string> ogList = new LinkedList<string>();
            ogList.AddLast("10 ");
            ogList.AddLast("20 ");
            ogList.AddLast("30 ");
            ogList.AddLast("40 ");
            ogList.AddLast("50 ");
            ogList.AddLast("60");
            Console.WriteLine("Original List: ");
            foreach (string str in ogList)
            {
                Console.Write(str);
            }
            LinkedList<string> newList = new LinkedList<string>();
            newList.AddLast("10 ");
            newList.AddLast("20 ");
            newList.AddLast("30 ");
            var newNode = newList.AddLast("40 ");
            newList.AddBefore(newNode, "444 ");
            newList.AddBefore(newNode, "333 ");
            newList.AddAfter(newNode, "50 ");
            newList.AddLast("60");
            Console.WriteLine(" ");
            Console.WriteLine("New List: ");
            foreach (string str in newList)
            {
                Console.Write(str);
            }
            Console.ReadKey();
        }
    }
}
