using System;

namespace FilterPattern
{
    public class Person
    {
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string MaritalStatus { get; private set; }

        public Person(String name, String gender, String maritalStatus)
        {
            this.Name = name;
            this.Gender = gender;
            this.MaritalStatus = maritalStatus;
        }
    }
}