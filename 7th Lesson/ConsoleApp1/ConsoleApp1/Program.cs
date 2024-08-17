using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays 
            // what is Arrays, How to work with them!

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"This is the numbers Array {numbers}");

            for ( int i = 0; i < numbers.Length; i++ )
            {
                Console.WriteLine($"this is the {i} number of the array : {numbers[i]}");
            }

            // searching via an Array
            Console.Write("Enter a number to search : ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            foreach (int item in numbers)
            {
                if (item == searchNumber)
                {
                    Console.WriteLine("Number that youve searched for has been found!!!");
                    break;
                }
            }

            // index of
            int position = Array.IndexOf(numbers, searchNumber);
            Console.WriteLine($"The number {searchNumber} found in the index of {position}");
            

            // Sorting an Array


            int[] unSortedNumbers = { 5, 5432, 23, 235, 254, 3432, 54325 };
            Array.Sort(unSortedNumbers);
            foreach (var item in unSortedNumbers)
            {
                Console.WriteLine(item);
            }

            // Reversing an Array

            int[] reverseArray = {1, 2, 3, 4, 5, 643, 53245 ,235 ,435, 432 };
            Array.Reverse(reverseArray);

            foreach (var item in reverseArray)
            {
                Console.WriteLine(item);
            }

            // Clearing an Array

            Array.Clear(numbers, default, numbers.Length);
            Array.Clear(unSortedNumbers, 0, unSortedNumbers.Length);
            Array.Clear(reverseArray, 0, reverseArray.Length);

            Console.WriteLine("Arrays Cleaned");

           
            Console.ReadLine();
        }
    }
}
