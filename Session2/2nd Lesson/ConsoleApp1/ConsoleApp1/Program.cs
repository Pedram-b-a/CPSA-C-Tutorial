using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Create a simple Calculator Program using OOP Technics???????
        class Calculator
        {
            private int firstNumber;
            private int secondNumber;
            private char theOperator;
            private double result;

            private void showResult()
            {
                Console.Clear();
                Console.WriteLine($"{this.firstNumber} {this.theOperator} {this.secondNumber} = {this.result}");
            }
            public void appRun()
            {

                while (true)
                {
                    try
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Enter the first number : ");
                        this.firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Enter the second Number : ");
                        this.secondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Please Enter the Operator : ");
                        this.theOperator = Convert.ToChar(Console.ReadLine());

                        if (this.theOperator.Equals('-'))
                        {
                            this.result = this.firstNumber - this.secondNumber;
                        }
                        else if (this.theOperator.Equals('+'))
                        {
                            this.result = this.firstNumber + this.secondNumber;
                        }
                        else if (this.theOperator.Equals('+'))
                        {
                            this.result = this.firstNumber * this.secondNumber;
                        }
                        else if (this.theOperator.Equals("/"))
                        {
                            this.result = this.firstNumber / this.secondNumber;
                        }
                        else
                        {
                            Console.WriteLine("The Operator Not Supported!!!");
                        }
                        showResult();
                        Console.ReadLine();
                        Console.Clear();
                    }
                    catch (Exception) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There was an error in the App!!!!");
                    }
                }
            }

            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();
                calculator.appRun();
            }
        }
    } 
}
