using System;
namespace OOP_assignments_2
{
    class Officer
    {

        private string name, surname;
        private int crimeSolved;
        private Int32 officerID;


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

        public int GetCrimeSolved()
        {
            return crimeSolved;
        }

        public void SetCrimeSolved(int value)
        {
            crimeSolved = value;
        }

        public int GetOfficerID()
        {
            return officerID;
        }

        public void SetOfficerID(int value)
        {
            officerID = value;
        }

        public Officer(string name, string surname, int officerID, int crimeSolved)
        {
            this.name = name;
            this.surname = surname;
            this.officerID = officerID;
            this.crimeSolved = crimeSolved;

        }

        public Officer()             //OR: public Officer() : this("John", "Gray", 1, "South", 0)
        {
            name = "John";
            surname = "Gray";
            officerID = 1;
            crimeSolved = 43;
        }

        
            

        public int CalculateLevel()

        {
            if (crimeSolved < 20 && crimeSolved >= 0)
            {
                return 1;
            }
            else if (crimeSolved < 40)
            {
                return 2;
            }

            else if (crimeSolved >= 40)
            {
                return 3;
            }
            return 0;
        }
        //public string toString()

        public override string ToString()
        {
            return  $"{name} {surname} (ID {officerID}, Crimes solved {crimeSolved}.";
        }

        
            
        

    }
}