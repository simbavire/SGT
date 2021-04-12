using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //a. Create seven Officers as the objects, two Districts as the objects and three Lawyers as the objects.
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
            // b. Add three Officers and two Lawyers in the first District and others Officers and Lawyers in the second District.
            district1.addNewPerson(officer1);
            district1.addNewPerson(officer2);
            district1.addNewPerson(officer3);
            district2.addNewPerson(officer4);
            district2.addNewPerson(officer5);
            district2.addNewPerson(officer6);
            district2.addNewPerson(officer7);
            district2.addNewPerson(lawyer1);
            district2.addNewPerson(lawyer2);
            district1.addNewPerson(lawyer3);
            
            
            // c. Print out all information about each District.
            Console.WriteLine(district1);
            Console.WriteLine(district2);
            // d. Edit the method calculateAvgLevelInDistrict() that only all Officers’ levels are summarized and divided by the amount of the Officers (not Lawyers) in this District. Please take a look here:
            // f. Create an arraylist for the Districts storage. Put both Districts in the Arraylist.
            
            ArrayList districts = new ArrayList();
            districts.Add(district1);
            districts.Add(district2);
            
            
            // g. Find out which District is with the highest number of Persons.
            /* District largest = (District)districts[0];
            foreach (District current in districts)
            {
                if (current.GetPersonsInTheDistrict().Length > largest.GetPersonsInTheDistrict().Length)
                {
                    largest = current;
                }
            }
            Console.WriteLine( "Largest: " + largest ); */

            //in case if both districts have similar perosn count
            int largestCount = 0;
            List<District> largest = new List<District>();
            foreach (District current in districts)
            {
                int currentCount = current.GetPersonsInTheDistrict().Length;
                if(currentCount > largestCount)
                {
                    largest.Clear();
                    largestCount = currentCount;
                    largest.Add(current);
                }
                else if (currentCount == largestCount)
                {
                    largest.Add(current);
                }
            }
            foreach (District district in largest)
            {
                Console.WriteLine("Largest: " + district);
            }
            
                

            

        }
    }
}
