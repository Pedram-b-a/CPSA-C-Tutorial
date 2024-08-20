using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // timeTable : Showing a n * m Table
        static void Main(string[] args)
        {
            Console.Write("Enter the First Number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= firstNumber; i++)
            {
                for (int j = 0; j <= secondNumber; j++)
                {
                    Console.Write("{0} x {1} = {2} ,", i, j, i * j);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
