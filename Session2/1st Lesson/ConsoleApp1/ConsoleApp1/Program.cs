using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Person
        {
            // class fields:
            private string firstName;
            private string lastName;
            private int age;
            private double height;
            private int weight;
            // class Propeties:
            public string FirstName { get; set; }

            public Person()
            {
                this.firstName = string.Empty;
                this.lastName = string.Empty;
                this.age = 0;
                this.weight = 0;
                this.height = 0;
            }

            public Person(string firstName, string lastName, int age, double height, int weight)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.height = height;
                this.weight = weight;
            }

            public void exersice(int callories)
            {
                if (callories > 0)
                {
                    Console.WriteLine($"before {this.weight}");
                    this.weight -= (callories / 100);
                    Console.WriteLine($"after {this.weight}");// this.weight = this.weight - (callories / 100);
                }
            }
            public double bmiCalculate()
            {
                return (this.weight / Math.Pow(this.height, 2));
            }
            public void personStatus()
            {
                Console.WriteLine($"name : {this.firstName} {this.lastName} | BMI : {this.bmiCalculate()}");
            }

            static void Main(string[] args)
            {
                // creating an object
                Person dude1 = new Person("Liam", "Houston", 24, 1.86, 86);
                dude1.exersice(200);
                dude1.personStatus();

                Console.ReadLine();
            }
        }
    }
}
