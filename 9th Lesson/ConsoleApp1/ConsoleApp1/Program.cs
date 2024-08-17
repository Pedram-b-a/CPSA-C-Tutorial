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
            /* Odd/Even Numbers 
               Create a dictionary which has two Keys of Odd & Even and the values of int lists */
            Dictionary<string, List<int>> numbers = new Dictionary<string, List<int>>()
            {
                { "Odd", new List<int>()},
                { "Even", new List<int>()}
            };

            List<int> number = new List<int>();
            int num;
            while (true)
            {
                Console.Write("Enter a number or -1 to exit: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
                else
                {
                    number.Add(num);
                }
            }    
            foreach (int item in number)
            {
                if (item % 2 == 0)
                {
                    numbers["Even"].Add(item);
                }
                else
                {
                    numbers["Odd"].Add(item);
                }
            }

            Console.WriteLine("The Even Numbers : ");
            foreach (var item in numbers["Even"])
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("The Odd Numbers : ");
            foreach(var item in numbers["Odd"])
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadLine();
        }
    }
}
