using System;
namespace OOP_assignments
{
    class Officer
    {

        private string name, surname, workingDistrict;
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

        public string GetWorkingDistrict()
        {
            return workingDistrict;
        }

        public void SetWorkingDistrict(string value)
        {
            workingDistrict = value;
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

        public Officer(string name, string surname, int officerID, string workingDistrict, int crimeSolved)
        {
            this.name = name;
            this.surname = surname;
            this.officerID = officerID;
            this.workingDistrict = workingDistrict;
            this.crimeSolved = crimeSolved;

        }

        public Officer()             //OR: public Officer() : this("John", "Gray", 1, "South", 0)
        {
            name = "John";
            surname = "Gray";
            officerID = 1;
            workingDistrict = "South";
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
            return ToString("C");
        }

        public string ToString(string fmt)
        {
            if (string.IsNullOrEmpty(fmt))
                fmt = "C";

            switch (fmt.ToUpperInvariant())
            {
                case "C":
                    return $"{name} {surname}.";
                case "B":
                    return $"{name} {surname}, working district: {workingDistrict}.";
                case "A":
                    return $"{name} {surname}, working district: {workingDistrict}, solved crimes: {GetCrimeSolved()}";
                default:
                    string msg = $"'{fmt}' is an invalid format string";
                    throw new ArgumentException(msg);
            }
        }

    }
}