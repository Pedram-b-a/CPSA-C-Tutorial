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
            /* Create a Password Checker Program
            in this program the user shall enter a pass word and save it 
            and then ask for the password agian and check if the password is correct
            and show the apropriate message
            EXTRA POINTS : cleaning the terminal for the first time the user saves thier Password*/

            string password;
            Console.Write("Enter your password to save : ");
            password = Console.ReadLine();
            //EXTRA POINTS :  Console.Clear();
            Console.Write("Enter Password Agian : ");
            
            string newPassword = Console.ReadLine();
            

            if (password.Equals(newPassword))
            {
                Console.WriteLine("Thats Correct!!!");
            }
            else //if (!password.Equals(newPassword))
            {
                Console.WriteLine("Thats Not Correct!!!");
            }
            Console.ReadLine();
        }
    }
}
