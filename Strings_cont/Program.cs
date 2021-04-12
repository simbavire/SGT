using System;
using System.Text.RegularExpressions;

namespace Strings_cont
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program where actions with String formatting as DateTime will be provided.
Please take a look at this tutorial:
https://docs.microsoft.com/en-us/dotnet/api/system.datetime.tolocaltime?view=net-5.0
and https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0
● Try to repeat the actions in the tutorial (see examples);
● Try to ask the user to write the day, month and year of the birthday in the console. Read all
values and create a DateTime objects and print out these in the console. */
            
           /*  Console.WriteLine("Write the day of birthday: ");
            string day = Console.ReadLine();
            Regex dayRegex = new Regex("^[0-3][0-9]$");
            bool dayIsValid = dayRegex.IsMatch(day);
           
            Console.WriteLine("Write the month of birthday: ");
            string month = Console.ReadLine();
            Regex monthRegex = new Regex("^[0, 3][0-9]$");
            bool monthIsValid = monthRegex.IsMatch(month);
           
            Console.WriteLine("Write the year of birthday: ");
            string year = Console.ReadLine();
            Regex yearRegex = new Regex("^[1, 2][0-9]{3}$");
            bool yearIsValid = yearRegex.IsMatch(year);
           
            if (dayIsValid == true && monthIsValid == true && yearIsValid == true )
            {
                Console.WriteLine($"Your birth data is {day}.{month}.{year}.");
            }
            else
            {Console.WriteLine("Wrong input.");} */

            //OOP

            Youth Eva = new Youth(18, "Books, Walking in park, TV shows");
            //Youth Raivis = new Youth (14, "gaming", "Minecraft");
            //Youth Diana = new Youth (21, "Netflix", "Instagram");
            Console.WriteLine ("Eva: " + Eva.Interests +" "+ Eva.Social +" "+ Eva.Age);
            //Console.WriteLine ("Raivis " + Raivis.Age +" "+ Raivis.Interests +" "+ Raivis.Social);
            //Console.WriteLine ("Diāna: " + Diana.Interests+" , vecums:  "+Diana.Age);
        }
    }
}
