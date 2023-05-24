using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    public class sortingClass
    {
        public void sortingMeth()
        {
            Console.WriteLine("Enter your gwa from 1st Sem to 2nd Sem: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                numbers[i] = int.Parse(inputArray[i]);
            }

            Console.WriteLine("\nOriginal Array:");
            PrintArray(numbers);

            int[] bubbleSortedArray = BubbleSort(numbers);
            Console.WriteLine("\nBubble Sorted Array (scending Order):");            
            PrintArray(bubbleSortedArray);

            int[] insertionSortedArray = InsertionSort(numbers);
            Console.WriteLine("\nInsertion Sorted Array (Ascending Order):");        
            PrintArray(insertionSortedArray);

            int[] selectionSortedArray = SelectionSort(numbers);
            Console.WriteLine("\nSelection Sorted Array (Ascending Order):");           
            PrintArray(selectionSortedArray);

            int[] bubbleSortedDescArray = BubbleSortDesc(numbers);
            Console.WriteLine("\nBubble Sorted Array (Descending Order):");
            PrintArray(bubbleSortedDescArray);

            int[] insertionSortedDescArray = InsertionSortDesc(numbers);
            Console.WriteLine("\nInsertion Sorted Array (Descending Order):");          
            PrintArray(insertionSortedDescArray);

            int[] selectionSortedDescArray = SelectionSortDesc(numbers);
            Console.WriteLine("\nSelection Sorted Array (Descending Order):");         
            PrintArray(selectionSortedDescArray);

        }

        static int[] BubbleSort(int[] arr)

        {
            int n = arr.Length;
            int[] sortedArray = (int[])arr.Clone();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        int temp = sortedArray[j];
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = temp;
                    }
                }
            }
            return sortedArray;
        }

        static int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            int[] sortedArray = (int[])arr.Clone();

            for (int i = 1; i < n; i++)
            {
                int key = sortedArray[i];
                int j = i - 1;

                while (j >= 0 && sortedArray[j] > key)
                {
                    sortedArray[j + 1] = sortedArray[j];
                    j = j - 1;
                }
                sortedArray[j + 1] = key;
            }
            return sortedArray;
        }

        static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            int[] sortedArray = (int[])arr.Clone();

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (sortedArray[j] < sortedArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = sortedArray[minIndex];
                sortedArray[minIndex] = sortedArray[i];
                sortedArray[i] = temp;
            }

            return sortedArray;

        }

        static int[] BubbleSortDesc(int[] arr)
        {
            int[] sortedArray = BubbleSort(arr);
            Array.Reverse(sortedArray);
            return sortedArray;
        }

        static int[] InsertionSortDesc(int[] arr)
        {
            int[] sortedArray = InsertionSort(arr);
            Array.Reverse(sortedArray);
            return sortedArray;
        }

        static int[] SelectionSortDesc(int[] arr)
        {
            int[] sortedArray = SelectionSort(arr);
            Array.Reverse(sortedArray);
            return sortedArray;

        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
