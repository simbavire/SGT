using System;

namespace OOP_assignment_4
{
    class  Person
    {
        private string name, surname;

        public Person(): this("John", "Smith"){}

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetSurname(string value)
        {
            surname = value;
        }

        public override string ToString()
        {
            return $"Person: {name}, {surname}."; 
        }
    }
}