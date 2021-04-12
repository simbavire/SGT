using System;

namespace OOP_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer Officer1 = new Officer( "Maris", "Skotelus", 1,"Ziepniekkalns", 56);
            Officer Officer2 = new Officer("John", "Smith", 2, "Purvciems", 25);
            Officer Officer3 = new Officer("Bebe", "Bornadi", 3, "Milano", 12);
            Console.WriteLine(Officer1 + ", Level: " + Officer1.CalculateLevel());
            Console.WriteLine(Officer2.ToString("A") + ", Level: " + Officer2.CalculateLevel());
            Console.WriteLine(Officer3.ToString("B") + ", Level: " + Officer3.CalculateLevel());

             //b. Create a new array Distric99 with the type Officer and put all created objects of the  +Officers in it.
             Officer [] District99 = new Officer[3];  //OR = {Officer1, Officer2, Officer3};
             District99[0] = Officer1;
             District99[1] = Officer2;
             District99[2] = Officer3;

             int leveOfOne = 0;
             int John = 0;
             foreach (Officer officer in District99)
             {
                if (officer.CalculateLevel() == 1){
                    leveOfOne++;
                };
                if (officer.GetName().Equals("John")){
                    John++;
                };
             }
             Console.WriteLine("The number of 1st lever: " + leveOfOne);
             Console.WriteLine("There are " + (District99.Length - leveOfOne) + " officers with the level larger than 1.");
             Console.WriteLine("There are " + John + " officiers with name John.");
             
//c. Find out how many Officers are with level 1 in the Distric99. 
//d. Find out how many Officers are with the level which is larger than 1 in the  Distric99. 
//e. Find out if there is any Officer with the name “John”. 
//Using Console class, ask for input of all Officer values in the console and create the 
//new  Officer in the system. Add it in the Distric99 array. 


        }
    }
}
