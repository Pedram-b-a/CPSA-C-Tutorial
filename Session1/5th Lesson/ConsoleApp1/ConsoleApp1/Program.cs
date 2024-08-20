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
            // Printing a sentence in reverse
            Console.Write("Enter a Sentence To reverse : ");
            string sentence = Console.ReadLine();

            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i]);
            }
            Console.ReadLine();
        }
    }
}
