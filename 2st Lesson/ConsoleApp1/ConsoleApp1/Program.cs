using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Creating our first program 
        // In this lesson We are Going To Learn About I/O 
        // We Use The Console.Write(), Console.Read()
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); //This is how we show a message in The Terminal Console.
            Console.Write("This is a Message"); // THis is how we show a message without starting a new line.

            Console.Write("Please Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello Dear " + name); // Getting a name and showing it in the terminal with a message.

            // Now We Start to Declare and Using Variables: 
            // This is how we Declare Variables : DataType VariableName = Value ;

            int number = 15;
            float number2 = 20.548f;
            string animal = "Wolf";

            Console.WriteLine("number + 53 : " + (number + 53));
            Console.WriteLine("number2 / 5 : " + number2 / 5);
            Console.WriteLine("animal : " + animal);


            // DataTypes in C#
            bool booleanVariable = false; // true OR false
            byte byteVariable = 0xFF; // 0 to 255 
            char charVariable = 'b'; // using the '' and having just a character
            decimal decimalVariable = 2_687m; // using the m in the end
            double doubleVariable = 5.687f; // using the f in the end 
            int intVariable = 58; // for showing the whole numbers

            Console.WriteLine("this is a boolean : " + booleanVariable);
            Console.WriteLine("this is a byte : " + byteVariable);
            Console.WriteLine("this is a char : " + charVariable);
            Console.WriteLine("this is a decimal : " + decimalVariable);
            Console.WriteLine("this is a double : " + doubleVariable);
            Console.WriteLine("this is a int : " + intVariable);

            Console.ReadLine();
        }
    }
}
