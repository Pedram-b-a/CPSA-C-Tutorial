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
            // Convert Function
            // We can convert datatypes like "8" String TO 8 Int

            int number;
            string stringNumber;
            Console.Write("Please Enter a number : ");
            stringNumber = Console.ReadLine();
            number = Convert.ToInt32(stringNumber); // Change the string to Int32

            // Tryparse : when we are collecting data and are not sertain that it is a number we use Int32.TryParse
            number = Int32.Parse(stringNumber);
            Console.Write(number);


            // Conditions : 
            // we Use Conditions When we Want to Devide The route of Our Program
            // We Have if And else (in some rare Situatuins We Use the Swicth Expression)

            Console.Write("Please Choose a number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 10)
            {
                Console.WriteLine("Your Number Is Greater Than Ten !!!");
            }
            else
            {
                Console.WriteLine("Your Number Is Smaller Than Ten !!!");
            }

            // else if : we can use this technic to create more than two conditions for our program

            Console.Write("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("Your Number Is Greeater Than Ten");
            }    
            else if (number == 10)
            {
                Console.WriteLine("your number is Ten");
            }
            else
            {
                Console.WriteLine("your number is smaller than Ten");
            }
           
            // switch statement : we use this statement so that we can check ONE variable Value 

            Console.Write("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            switch(number)
            {
                case 0:
                    Console.WriteLine("your number is Zero");
                    break;
                case 1:
                    Console.WriteLine("your number is One");
                    break;
                case 2:
                    Console.WriteLine("your number is two");
                    break;
                default:
                    Console.WriteLine("your number is {0} {1}", number, number +2);
                    break;
            }


            // Loops : We Have 3 kind of Loops In C# : 
            // 1-while loop , 2-for loop , 3- forEach loop.
            // loops are designed to perform a certian task multiple times 

            // While Loop
            //while (true)
            //{
            //    Console.WriteLine("Inside the loop :) "
            //}
            // This Loop Would Never End Because The Stop Condition is Not Declared!!!

            string check = " ";
            while (check != "stop")
            {
                Console.WriteLine(check);
                Console.Write("Enter Stop or Anything : ");
                check = Console.ReadLine();
            }

            // For Loop 
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }

            // For Each
            // for each can be used in the way that each element of a List or Array

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // rawString : We can use variables in a string format such as
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            string sentence = $"Hello {name} With the age of {age}";

            Console.WriteLine(sentence);
            Console.ReadLine();






















            if (number == 1) {Console.Clear();}
            else if (number == 2) { Console.WriteLine("OK"); }
            





        }
    }
}
