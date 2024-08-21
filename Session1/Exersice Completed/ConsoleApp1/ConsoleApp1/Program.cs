using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static Dictionary<string, string> contacts = new Dictionary<string, string>();

        static void Main(string[] args)
        {

            // functions delete and exeptions delete
            
            // Simple Contact Manager
            // Use a Simple List-Dictionary Based DataBase
            // there is a list of Dictionaries
            // The Data That Are Going to Save : contact, Contact number
            // Functions : Add, Delete, Search, DisplayAll

            while (true)
            {
                Console.WriteLine("Welcome to the Contact Manager App");
                Console.WriteLine("Enter 1 for Displaying Contacts");
                Console.WriteLine("Enter 2 for Adding Contact");
                Console.WriteLine("Enter 3 for Searching");
                Console.WriteLine("Enter 4 for Delete a contact");
                Console.WriteLine("Enter 0 to Exit");
                Console.WriteLine("............................");
                try
                {
                    char choice = Convert.ToChar(Console.ReadLine());
                    if (choice == '1')
                    {
                        Console.Clear();
                        displayContacts();
                        Console.Write("Press Enter To Back To the Menu");
                        Console.ReadLine();
                    }
                    else if (choice == '2')
                    {
                        Console.Clear();
                        Console.Write("Enter the Name : ");
                        string name = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("name Cannot be Empty");
                            return;
                        }
                        Console.Write("Enter the Contact : ");
                        string contact = Console.ReadLine();
                        if (contacts.ContainsKey(name))
                        {
                            Console.WriteLine("This Contact Already Exist!!!");
                            return;
                        }
                        addContact(name, contact);
                        Console.WriteLine("Contact Added SuccessFully");
                        Console.Write("Press Enter To Back To the Menu");
                        Console.ReadLine();
                    }
                    else if (choice == '3')
                    {
                        Console.Clear();
                        Console.Write("Enter a name to search : ");
                        string searchName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(searchName))
                        {
                            searchContact(searchName);
                        }
                        else
                        { 
                            Console.WriteLine("Please Enter a valid Name");
                            return;
                        }
                        Console.Write("Press Enter To Back To the Menu");
                        Console.ReadLine();
                    }
                    else if (choice == '4')
                    {
                        Console.Clear();
                        Console.Write("Enter a name to Delete");
                        string deleteName = Console.ReadLine();
                        deleteContact(deleteName);

                    }
                }
                catch (Exception mamad)
                {
                    Console.WriteLine($"An Error Has Ocourd!!! Restart the App {mamad.Message}");
                }
            }
        }
        static void displayContacts()
        {
            Console.Clear();
            Console.WriteLine("Display Contacts");
            foreach (KeyValuePair<string, string> item in contacts)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

        static void addContact(string name, string contact)
        {
            try
            {
                contacts.Add(name, contact);
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e); 
            }

        }

        static void searchContact(string searchName)
        {
            if (contacts.ContainsKey(searchName))    
            {
                Console.WriteLine($"contact found : {contacts[searchName]}");
            }
            else
            {
                Console.WriteLine($"The Contact with the name of {searchName} Not Found!!!");
            }
        }

        static void deleteContact(string fullName)
        {
            if (contacts.ContainsKey(fullName))
            {
                contacts.Remove(fullName);
                Console.WriteLine($"Contact with the name of {fullName} has Deleted!!!");
            }
            else
            {
                Console.WriteLine($"The Contact of {fullName} not found!!!");
            }
        }
    }
}
