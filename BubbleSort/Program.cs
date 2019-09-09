using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };
            Print();
            bool sorted = false;
            int value = 0;
            int value2 = 0;
            //while the array is not sorted...
            while (!sorted)
            {
                sorted = true;
                Print();
                //stay in bound in array
                for (int i = 0; i < arrayToSort.Length-1; i++)
                {
                    //...swaps the num in the array to the right order
                    if (arrayToSort[i] > arrayToSort[i+1])
                    {
                        value = arrayToSort[i];
                        value2 = arrayToSort[i + 1];

                        arrayToSort[i] = value2;
                        arrayToSort[i + 1] = value;

                        sorted = false;
                    }
                }
                
            }
            //print the array's num 
            void Print()
            {
                for (int i = 0; i < arrayToSort.Length; i++)
                {
                    Console.WriteLine(arrayToSort[i]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        
    }
}
