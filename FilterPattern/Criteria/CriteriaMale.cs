using System.Collections.Generic;

namespace FilterPattern.Criteria
{
    public class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();

            foreach (var person in persons)
            {
                if (person.Gender.Equals("Male"))
                {
                    malePersons.Add(person);
                }
            }
            
            return malePersons;
        }    
    }
}