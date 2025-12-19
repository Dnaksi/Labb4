using System.Collections.Generic;

namespace test
{
    internal class Program
    {
        // Made a list for the people
        static List<Person> people = new List<Person>();
        static void Main(string[] args)

        {
            string Line = ("-------------------");
            Console.WriteLine("Welcome to Datastealer list \n");
            // Made a loop to run the program multiple times
            while (true)
            {
                Person person = new Person();

                Console.WriteLine("1. Add a person to the list\n2. Write out the list\n3. End the program\n");
                var input = Console.ReadLine();
                // Made a swich statement to choose what should happen
                switch (input)
                {
                    case "1":
                        // Made code to add a person to the list
                        person.AddPerson();
                        break;
                    case "2":
                        // Made code to write out the list of people
                        person.ListPersons();
                        break;
                    case "3":
                        // Code to end the program
                        return; 
                    default:
                        //In case of input outside the permited values 
                        Console.WriteLine("\n" + Line);
                        Console.WriteLine("Invalid option, please try again");
                        Console.WriteLine(Line + "\n");
                        break;
                }     
            }
        }

    }
}

