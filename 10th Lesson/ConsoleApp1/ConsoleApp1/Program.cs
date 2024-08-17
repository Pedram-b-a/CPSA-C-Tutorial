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
            /* Functions  */
            // how to call a function
            welcome("Hello there");
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 4568 };
            Console.WriteLine(arraySum(numbers));


            Console.WriteLine(max(55, 6));
            Console.ReadLine();

        }
        // static void : Static Means that you can use this Function in its own class
        // Void Means that the function do NOT Return any Data
        static void welcome(string message)
        {
            Console.WriteLine(message);
        }

        // Return Functions : Means that they can and must return a value 
        static int max(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else if (number2 < number1)
            {
                return number2;
            }
            else
            {
                return number1;
            }
        }

        static float arraySum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            { 
                sum += number;
            }
            return sum;
        }


    }
}
