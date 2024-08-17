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
            // Lists and Dictionry
            // Lists can be added when used in a situation

            List<int> listNumbers = new List<int>()
            {
                1, 2, 3, 4
            };
            listNumbers.Add(1);
            listNumbers.Add(2);
            listNumbers.Add(3);
            listNumbers.Remove(0);

            List<int> listNumber2 = new List<int>();
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number : ");
                listNumber2.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (int i in listNumber2)
            {
                Console.WriteLine(i);
            }

            // Dictionary
            // Dictionary is created whit the concept of (Key: Value) Structure
            // Where any specific key can show a specefic value

            Dictionary<string ,string> names = new Dictionary<string ,string>();

            names.Add("Mohamad", "Abbasi");
            names.Add("jack", "Johnson");

            Console.WriteLine(names["jack"]);

            Dictionary<int, string> values = new Dictionary<int, string>()
            {
                {1, "One"}, {2, "Two"}, {3, "Three"}
            };

            foreach (KeyValuePair<int, string> pair in values)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
            Console.ReadLine();
        }
    }
}
