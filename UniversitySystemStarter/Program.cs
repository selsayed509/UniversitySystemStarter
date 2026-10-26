using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Composition: the university creates its own departments.
            University abertay = new University("Abertay University", "Dundee");
            Department computing = abertay.AddDepartment("Computing", "Design, Informatics and Business");
            Department games = abertay.AddDepartment("Games", "Design, Informatics and Business");

            // Aggregation: students are created outside, then added.
            Student amira = new Student("NI003", "Amira", new DateTime(2005, 5, 20), "07000 000003",
                                        "3 Perth Road", "2400123", "BSc Computing");
            Student ben = new Student("NI004", "Ben", new DateTime(2004, 11, 8), "07000 000004",
                                      "4 Perth Road", "2400456", "BSc Computer Games");
            computing.AddStudent(amira);
            games.AddStudent(ben);

            // Inherited and overridden members, used through the Person type.
            List<Person> people = new List<Person> { amira, ben };
            foreach (Person p in people)
            {
                Console.WriteLine(p.GetRole() + ": " + p.GetContactInfo());
            }

            // Navigating the associations.
            Student found = abertay.GetDepartment("Games").GetStudent("Ben");
            Console.WriteLine(found.Name + " is registered with " + found.Department.Name);

            // Composition: removing the department removes it from the university.
            abertay.RemoveDepartment(games);
            Console.WriteLine("Games department found: " + (abertay.GetDepartment("Games") != null));
            Console.WriteLine("Ben still exists: " + ben.Name);

            // Person p = new Person(...);   // error: Person is abstract
        }
    }
}
