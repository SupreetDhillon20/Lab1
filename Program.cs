using System.ComponentModel.Design;

namespace lab1
{
    //Creating person class
    class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public int age;
        public string favoriteColour;
        public bool isWorking;

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name of person is {firstName} {lastName}");
            Console.WriteLine($"Id of person is {personId}");
            Console.WriteLine($"{firstName}'s favourite colour is {favoriteColour}");
        }

        //Changing favorite colour
        public void ChangeFavoriteColour() 
        {
            favoriteColour = "White";
        }

        //Increasing a person's age by 10 years
        public int GetAgeInTenYears() 
        {
            return age + 10;
        }

        //Displaying information in list form
        public override string ToString()
        {
            return $"PersonId: {personId} \nFirstName: {firstName} \nLastName: {lastName} \nFavouriteColour: {favoriteColour} \nAge: {age} \nIsWorking: {isWorking}";
        }
    }

    //Creating relation class
    class Relation
    {
        public string RelationshipType;

        //Displaying relationship between two persons
        public void ShowRelationShip(Person person1,Person person2)
        {
            Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {RelationshipType}");
        }
    }

    //Creating main class
    class Mainclass
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            Person person1 = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
            Person person2 = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
            Person person3 = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
            Person person4 = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);

            //Displaying Gina's information
            Console.WriteLine($"{person2.personId}: {person2.firstName} {person2.lastName}'s favorite colour is {person2.favoriteColour}");

            //Displaying Mike's information in list form'
            Console.WriteLine(person3);

            //Changing Ian's favorite colour to white
            person1.ChangeFavoriteColour();
            Console.WriteLine($"{person1.personId}: {person1.firstName}{person1.lastName}'s favorite colour is {person1.favoriteColour}");

            //Displaying Mary's age after 10 years
            Console.WriteLine($"{person4.firstName}{person4.lastName}'s age in 10 years is {person4.GetAgeInTenYears()}");

            Relation relation1 = new Relation { RelationshipType = "Sisterhood" };
            Relation relation2 = new Relation { RelationshipType = "Brotherhood" };

            //Displaying relations
            relation1.ShowRelationShip(person2, person4);
            relation2.ShowRelationShip(person1, person3);

            // Display average age, youngest and oldest person
            int totalAge = 0;
            int youngestAge = int.MaxValue;
            int oldestAge = int.MinValue;
            Person youngest = null;
            Person oldest = null;

            foreach (var person in persons)
            {
                totalAge += person.age;

                if (person.age < youngestAge)
                {
                    youngestAge = person.age;
                    youngest = person;
                }

                if (person.age > oldestAge)
                {
                    oldestAge = person.age;
                    oldest = person;
                }

                if (person.favoriteColour.Equals("Blue", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Person who likes the blue colour: \n{person.ToString()}");
                }

                if (person.firstName.StartsWith("M"))
                {
                    Console.WriteLine(person);
                }
            }

            double avgAge = totalAge / (double)persons.Count;
            Console.WriteLine($"Average age is: {avgAge}");
            Console.WriteLine($"The youngest person is: {youngest.firstName}");
            Console.WriteLine($"The oldest person is: {oldest.firstName}");
        }   
    }
}
