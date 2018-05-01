using System.Collections.Generic;

namespace FilterPattern.Criteria
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();

            foreach (var person in persons)
            {
                if (person.Gender.Equals("Female"))
                {
                    femalePersons.Add(person);
                }
            }

            return femalePersons;
        }
    }
}