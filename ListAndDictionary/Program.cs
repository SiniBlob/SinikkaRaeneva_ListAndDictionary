namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            Console.WriteLine("Whom do you want to add to the file?");
            string person = Console.ReadLine();
            // TODO 2: Validate if the person already exists in the personList.
            if (personList.Contains(person) == true) { Console.WriteLine($"{person} is already on the file"); }
            // TODO 3: Add the person to the personList if they don't already exist.
            else { 
                personList.Add(person);
                Console.WriteLine($"{person} has been added to the file");
            }

            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            if (personAgeDictionary.ContainsKey(person)) { 
                Console.WriteLine($"{person}'s age is already in our system."); }
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            else
            {
                Console.WriteLine($"We don't have {person}'s age on file. How old are they?");
                int personAge = Convert.ToInt32( Console.ReadLine() );
                personAgeDictionary.Add(person, personAge);
                Console.WriteLine($"Thank you! {person} being {personAge} years old has been added to our file.");

            }
            //         NOTE!: Remember to add both TKey and TValue
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.
        }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            Console.WriteLine("Whom would you like to remove from our file?");
            string person = Console.ReadLine();
            // TODO 9: Remove the person from personList if they exist.
            if (personList.Contains(person) == true )
            {
                personList.Remove(person);
                Console.WriteLine($"{person} has been removed from our file.");
            }

            else { Console.WriteLine($"{person} doesn't exist on our file."); }
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            if (personAgeDictionary.ContainsKey(person)) {
                personAgeDictionary.Remove(person);
                Console.WriteLine($"{person}'s age has been removed from our file");
            }
            else
            {
                Console.WriteLine($"{person}'s age wasn't on our file.");
            }
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            Console.WriteLine("Whom would you like to find?");
            string person = Console.ReadLine();
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            if(personList.Contains(person) )
            {
                Console.WriteLine($"{person} does exist in our files");
            }
            else
            {
                Console.WriteLine($"{person} doesn't exist in our files");
            }
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
            if (personAgeDictionary.ContainsKey(person))
            {
                Console.WriteLine($"{person}'s age is also in our files, they are {personAgeDictionary[person]} years old");
            }
            else
            {
                Console.WriteLine($"{person}'s age didn't exist in our files.");
            }
        }

        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine("{0}\n", personList[i]);
            }
            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            for (int i = 0;i < personAgeDictionary.Count; i++)
            {
                Console.WriteLine("Name: {0}\nAge: {1}\n", personAgeDictionary.ElementAt(i).Key, personAgeDictionary.ElementAt(i).Value);
            }
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
            if (personList.Count == 0)
            {
                Console.WriteLine("The file is empty");
            }

            if (personAgeDictionary.Count == 0) { Console.WriteLine("We have no ones age on file."); }
        }
    }
}
