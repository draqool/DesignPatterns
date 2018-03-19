using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ReduceMap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = Person.GetListOfPerson;
            int ageTotal = 0;

            Parallel.ForEach
            (
                persons,
                () => 0,
                (person, loopState, subtotal) => subtotal + person.Age,
                (subtotal) => Interlocked.Add(ref ageTotal, subtotal)
            );

            Console.WriteLine($"Age total: {ageTotal}");
            Console.ReadKey();
        }
    }
}
