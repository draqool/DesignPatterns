using System.Collections.Generic;

namespace FilterPattern.Criteria
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();

            foreach (var person in persons)
            {
                if (person.MaritalStatus.Equals("Single"))
                {
                    singlePersons.Add(person);
                }
            }

            return singlePersons;
        }
    }
}