using System;

namespace OOP_assignment_4
{
    class Officer : Person
    {
        private int crimeSolved;
        private Int32 officerID;

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

        public Officer(string name, string surname, int officerID, int crimeSolved) : base(name, surname)
        {
            
            this.officerID = officerID;
            this.crimeSolved = crimeSolved;

        }

        public Officer() : this("John", "Gray", 1, 0)
        {
          
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
            return  $"{GetName()} {GetSurname()} (ID {officerID}, Crimes solved {crimeSolved}.";
        }
    }
}