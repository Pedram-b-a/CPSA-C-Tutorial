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
            // Exeption Handling 
            // handling the errors of the program using Try Catch Method

            // Console.Write("Enter a number : ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // If we enter 2000000000000000
            // we get the System.OverflowException Error and the program will crash
            while (true)
            {
                try
                {
                    Console.Write("Enter a number : ");
                    int number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Please Enter Only nubmers {e.Message}");
                }
                catch (OverflowException G)
                {
                    Console.WriteLine($"Please Enter Smaller Number {G.Message} ");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something Went Wrong {e.Message}");
                }
            }
            Console.ReadLine();
        }
    }
}
