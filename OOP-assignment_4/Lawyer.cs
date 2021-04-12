using System;

namespace OOP_assignment_4
{
    class Lawyer : Person
    {
         private Int32 lawyerID;
        private int helpedInCrimesSolving;

        public Lawyer(): this("Jane", "Smith", 12, 2){}

        public Lawyer(string name, string surname, Int32 lawyerID, int helpedInCrimesSolving) : base (name, surname)
        {
            //SetName(name); //variable comes from no-argument constr. Person
            //SetSurname(surname); //variable comes from no-argument constr. Person
            this.lawyerID = lawyerID;
            this.helpedInCrimesSolving = helpedInCrimesSolving;
        }

        public int GetLawyerID()
        {
            return lawyerID;
        }

        public void SetLawyerID(int value)
        {
            lawyerID = value;
        }

        public int GetHelpedInCrimesSolving()
        {
            return helpedInCrimesSolving;
        }

        public void SetHelpedInCrimesSolving(int value)
        {
            helpedInCrimesSolving = value;
        }

        public override string ToString()
        {
            return base.ToString() + $"Lawyer ID: {lawyerID}, helped in {helpedInCrimesSolving} crimes solving."; 
        }
    }
}