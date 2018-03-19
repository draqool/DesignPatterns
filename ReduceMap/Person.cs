using System.Collections.Generic;

namespace ReduceMap
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static List<Person> GetListOfPerson
        {
            get
            {
                return new List<Person>()
                {
                    new Person { Name = "Artur", Age = 11 },
                    new Person { Name = "Adam", Age = 19 },
                    new Person { Name = "Karol", Age = 40 },
                    new Person { Name = "Bartek", Age = 30 }
                };
            }
        }
    }
}