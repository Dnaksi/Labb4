using System.Collections.Generic;

namespace test
{
    internal class Program
    {

        static List<Person> people = new List<Person>();
        static void Main(string[] args)

        {
            string Line = ("-------------------");
            Console.WriteLine("Welcome to Datastealer list \n");

            while (true)
            {
                Person person = new Person();

                Console.WriteLine("1. Add a person to the list\n2. Write out the list\n3. End the program\n");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        
                        person.AddPerson();
                        
                        // Code to add the person to the list
                        break;
                    case "2":
                        person.ListPersons();
                        // Code to write out the list of people
                        break;
                    case "3":
                        return; // End the program
                    default:
                        Console.WriteLine("\n" + Line);
                        Console.WriteLine("Invalid option, please try again");
                        Console.WriteLine(Line + "\n");
                        break;
                }     
            }
        }

    }
}
