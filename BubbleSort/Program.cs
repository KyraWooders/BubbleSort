using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static int swaps = 0;
        static int loops = 0;
        static void Main(string[] args)
        {
            //int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };
            int[] arrayToSort =
            {
                14, 65, 63, 1, 54, 89, 84, 9, 98, 57,
                71, 18, 21, 84, 69, 28, 11, 83, 13, 42,
                64, 58, 78, 82, 13, 9, 96, 14, 39, 89, 
                40, 32, 51, 85, 48, 40, 23, 15, 94, 93,
                35, 81, 1, 9, 43, 39, 15, 17, 97, 52
            };
            Print();
            Console.WriteLine("");
            //BubbleSort(arrayToSort);
            //OptimizedBubbleSort(arrayToSort);
            CocktailShakerSort(arrayToSort);
            Print();
            //print the array's num 
            void Print()
            {
                for (int i = 0; i < arrayToSort.Length; i++)
                {
                    Console.WriteLine(arrayToSort[i]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("loops: " + loops);
            Console.WriteLine("swaps: " + swaps);
            Console.ReadKey();


        }
        public static void CocktailShakerSort(int[] arrayToSort)
        {
            int start = 0;
            int end = arrayToSort.Length - 1;
            int pass = 0;
            bool sorted = false;
            int value = 0;
            int value2 = 0;
            //while the array is not sorted...
            while (!sorted)
            {
                sorted = true;
                for (int i = start; i < end; i++)
                {
                    //...swaps the num in the array to the right order going to the right 
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        value = arrayToSort[i];
                        value2 = arrayToSort[i + 1];

                        arrayToSort[i] = value2;
                        arrayToSort[i + 1] = value;

                        sorted = false;
                        swaps++;

                    }
                    loops++;
                }
                end--;
                //stay in bound in array
                for (int i = end; i > start; i--)
                {
                    //...swaps the num in the array to the right order going to the left
                    if (arrayToSort[i] < arrayToSort[i - 1])
                    {
                        value = arrayToSort[i];
                        value2 = arrayToSort[i - 1];

                        arrayToSort[i] = value2;
                        arrayToSort[i - 1] = value;

                        sorted = false;
                        swaps++;

                    }
                    loops++;
                }
                start++;
                pass++;
            }
        }
        public static void OptimizedBubbleSort(int[] arrayToSort)
        {
            int pass = 1;
            bool sorted = false;
            int value = 0;
            int value2 = 0;
            //while the array is not sorted...
            while (!sorted)
            {
                sorted = true;
               
                //stay in bound in array
                for (int i = 0; i < arrayToSort.Length - pass; i++)
                {
                    //...swaps the num in the array to the right order
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        value = arrayToSort[i];
                        value2 = arrayToSort[i + 1];

                        arrayToSort[i] = value2;
                        arrayToSort[i + 1] = value;
                        
                        sorted = false;
                        swaps++;
                        
                    }
                    loops++;
                }
                pass++;
            }
        }
        public static void BubbleSort(int[] arrayToSort)
        {
            
            bool sorted = false;
            int value = 0;
            int value2 = 0;
            //while the array is not sorted...
            while (!sorted)
            {
                sorted = true;

                //stay in bound in array
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    //...swaps the num in the array to the right order
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        value = arrayToSort[i];
                        value2 = arrayToSort[i + 1];

                        arrayToSort[i] = value2;
                        arrayToSort[i + 1] = value;

                        sorted = false;
                        swaps++;

                    }
                    loops++;
                }

            }
        }
    }
   
}
