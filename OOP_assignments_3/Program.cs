using System;
using System.Collections.Generic;

namespace OOP_assignments_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lawyer lawyer1 = new Lawyer();
            Lawyer lawyer2 = new Lawyer("Maris", "Resnis", 11, 2);
            Lawyer lawyer3 = new Lawyer("Kate", "Snow", 23, 44);
            Officer officer1 = new Officer("Kate", "Snog", 123, 4);
            Officer officer2 = new Officer("Katrin", "Snow", 3, 4);
            Officer officer3 = new Officer("Kath", "Negan", 0, 42);
            Officer officer4 = new Officer("Late", "Inog", 13, 14);
            Officer officer5 = new Officer("May", "Snog", 263, 45);
            Officer officer6 = new Officer("Gane", "Soul", 213, 9);
            Officer officer7 = new Officer("Ruth", "Winter", 823, 8);
            District district1 = new District();
            District district2 = new District("Centrs", "Riga", 2, new Officer[0]);
            
            district1.addNewOfficer(officer1);
            district1.addNewOfficer(officer2);
            district1.addNewOfficer(officer3);
            district2.addNewOfficer(officer4);
            district2.addNewOfficer(officer5);
            district2.addNewOfficer(officer6);
            district2.addNewOfficer(officer7);
            //Console.WriteLine(district1);
            //Console.WriteLine(district2);
            List<Lawyer> lawyers = new List<Lawyer>();
            //ArrayList lawywers = new ArrayList();
            lawyers.Add(lawyer1);
            lawyers.Add(lawyer2);
            lawyers.Add(lawyer3);

            int crimesSolvedByLawyers = 0;
            foreach (Lawyer lawyer in lawyers)
            {
                crimesSolvedByLawyers += lawyer.GetHelpedInCrimesSolving();
            }
            Console.WriteLine("Lawyers helped in " + crimesSolvedByLawyers +  " crimes solving.");

            //find out which Lawyer has helped the most
            Lawyer mostHelpful = lawyers[0];
            for (int i = 0; i < lawyers.Count; i++)
            {
                Lawyer current = lawyers[i];
                if (mostHelpful.GetHelpedInCrimesSolving() < current.GetHelpedInCrimesSolving())
                {
                    mostHelpful = current;
                }
            }
            
            Console.WriteLine($"The {mostHelpful} helped most in crimes solveing.");
            
            
        }
    }
}
