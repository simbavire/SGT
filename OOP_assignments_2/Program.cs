using System;

namespace OOP_assignments_2
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
        }
    }
}
