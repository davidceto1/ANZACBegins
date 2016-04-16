using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class C
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                people.Add(new Person(input[0], input[1]));
            }

            people.Sort((x, y) => string.Compare(x.FullName, y.FullName));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(people[i].FirstName + " " + people[i].LastName);
            }

            Console.ReadKey();
        }
    }

    class Person
    {
        private string firstName;
        private string lastName;
        private string fullName;

        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
            fullName = last + " " + first;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }
    }
}
