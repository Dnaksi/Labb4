using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    
    internal class Person
    {
       
        static List<Person> people = new List<Person>();

        public string Name {  get; set; }
        public Hair Hair { get; set; }
        public Gender Gender { get; set; }
        public string Eyecolor { get; set; }
        public DateOnly BirthDate { get; set; }


        

        public Person()
        {


            Hair = new Hair();
            
        }

        public override string ToString()
        {
            return $"Name: {Name}\n{Hair}\nGender: {Gender}\nBirthDate: {BirthDate}\nEyecolor: {Eyecolor}";
        }

        public void ListPersons()
            

        {
            string Line = ("-------------------");

            if (people.Count == 0)
            {
                Console.WriteLine("No persons in the list.");
                return;
            }
            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
                Console.WriteLine(Line);
            }
        }


        public void AddPerson()
        {
            string Line = ("-------------------");
            string failStr = ("Invalid Input! You can´t leave it empty");
            string failInt = ("Invalid input. Please enter a valid number for");
            Person person = new Person
            {
                Hair = new Hair()
            };

            while (true)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                bool allDigits = name.All(char.IsDigit);
                if (!string.IsNullOrEmpty(name) && !allDigits)
                {
                    person.Name = name;
                    break;
                }
                Console.WriteLine("\n" + Line);
                Console.WriteLine($"{failStr} or only use numbers.");
                Console.WriteLine(Line + "\n");
            }
           
            while (true) 
            {
                Console.WriteLine("Hair color:");
                string hairColor = Console.ReadLine();
                bool containsInt = hairColor.Any(char.IsDigit);
                if (!string.IsNullOrWhiteSpace(hairColor) && !containsInt)
                {
                    Hair hair = person.Hair;
                    hair.HairColor = hairColor;
                    person.Hair = hair;
                    break;

                }
                Console.WriteLine("\n" + Line);
                Console.WriteLine($"{failStr} or use any numbers.");
                Console.WriteLine(Line + "\n");
            }
           while (true)
            {
                Console.WriteLine("Hair length(CM) :");
                string hLength = Console.ReadLine();
                
                if(int.TryParse(hLength, out int hairLength) && !string.IsNullOrEmpty(hLength))
                {
                    Hair hair = person.Hair;
                    hair.HairLength = hairLength;
                    person.Hair = hair;
                   
                     break;
                }

                Console.WriteLine("\n" + Line);
                Console.WriteLine($"{failInt} hair length:");
                Console.WriteLine(Line + "\n");
            }
            while (true)
            { 
                Console.WriteLine("Birth Date (YYYY-MM-DD):");
                if (DateOnly.TryParseExact(Console.ReadLine(),"yyyy-MM-dd",out DateOnly birthDate))
                {
                    person.BirthDate = birthDate;
                    break;
                }
                Console.WriteLine("\n" + Line);
                Console.WriteLine($"{failInt} birth date:");
                Console.WriteLine(Line + "\n");
            }
            while (true)
            {
                Console.WriteLine("Eye Color:");
                string eyeColor = Console.ReadLine();
                bool containsInt = eyeColor.Any(char.IsDigit);
                if(!string.IsNullOrWhiteSpace(eyeColor) && !containsInt)
                {
                    person.Eyecolor = eyeColor;
                    break;
                }
                Console.WriteLine("\n" + Line);
                Console.WriteLine($"{failStr} or with any numbers.");
                Console.WriteLine(Line + "\n");
            }

            Console.WriteLine($"Gender, choose a number:\n1. Woman\n2. Man\n3. NonBinary\n4. Other");
                int genderInput;
            while (!int.TryParse(Console.ReadLine(), out genderInput) || genderInput < 1 || genderInput > 4)
            {
                Console.WriteLine("\n" + Line);
                Console.WriteLine("Invalid Choice. Enter 1-4 ");
                Console.WriteLine(Line + "\n");

            }
                person.Gender = (Gender)(genderInput );


         


            people.Add(person);
            Console.WriteLine("\n" + Line);
            Console.WriteLine("Person added.");
            Console.WriteLine(Line + "\n");

        }


    }
}
