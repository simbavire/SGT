using System;
using System.Collections;

namespace OOP_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer officer1 = new Officer();
            Officer officer2 = new Officer("Maris", "Sils", 123, 23);
            Officer officer3 = new Officer("Vita", "Turka", 24, 45);
            Officer officer4 = new Officer("Gints", "Sauls", 4555, 45);
            Officer officer5 = new Officer("Joe", "Black", 4555, 12);
            District district1 = new District();
            District district2 = new District("West", "Riga", 1002, new Officer [0]);
            district1.addNewOfficer(officer1);
            district1.addNewOfficer(officer2);
            district1.addNewOfficer(officer3);
            district2.addNewOfficer(officer4);
            district2.addNewOfficer(officer5);
            Console.WriteLine(district1);
            Console.WriteLine(district2);
            district2.RemoveOfficer(officer4);
            Console.WriteLine(district1.CalculateAvgLevelInDistrict());
            Console.WriteLine(district2.CalculateAvgLevelInDistrict());
            ArrayList districts = new ArrayList();
            districts.Add(district1);
            districts.Add(district2);
            Console.WriteLine(districts.Count);

            int offierCount = 0;
            foreach (District district in districts)
            {
                foreach (Officer officer in district.GetOfficersInTheDistrict())
                {
                    offierCount++;
                }
            }
            Console.WriteLine("There are " + offierCount + " officers in both districts.");
            Console.WriteLine((district1.CalculateAvgLevelInDistrict() + district2.CalculateAvgLevelInDistrict())/2);

            if (district1.CalculateAvgLevelInDistrict() == district2.CalculateAvgLevelInDistrict())
            {
                Console.WriteLine("Both districts are at the same level.");
            }
            else if (district1.CalculateAvgLevelInDistrict() > district2.CalculateAvgLevelInDistrict())
            {
                Console.WriteLine("District 1 is the best based level.");
            }
            else
            {
                Console.WriteLine("District 2 is th ebest based level.");
            }
        }
    }
}
