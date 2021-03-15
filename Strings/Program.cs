using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Raivis Reinfelds";
            Console.WriteLine(txt.ToUpper());   
            Console.WriteLine(txt.ToLower()); 
            string firstName = "Janis";
            string lastName = "Berzins";

//string name = firstName + " " +  lastName;
//Console.WriteLine(name);
            string name = string.Concat(firstName,  lastName);
            Console.WriteLine(name); // no space between them
            string myString = "Hello there!";
            Console.Write(myString[0]); // Outputs "H"
            Console.WriteLine(myString[1]); // Outputs "e"
            Console.WriteLine(myString.IndexOf("h")); // Outputs ”4"
            Console.WriteLine("**************************");

            string fullName = "Janis Berzins 🤴";
            //int charPos = fullName.IndexOf("z"); // Location of the letter B
            string lName = fullName.Substring(fullName.IndexOf("z")); // Get last name
            Console.WriteLine(lName ); // Print the result

            string userInput;
            Console.Write("Input the string : ");
            userInput = Console.ReadLine();
            int howManyLetters = userInput.Length;
            Console.Writeline($"Length of the string is : {howManyLetters}");
            int inputLength = userInput.Length - 1;
            Console.Write("The characters of the string in reverse are:\n");
            while (inputLength >= 0)
            {
            Console.Write("{0}", userInput[inputLength-1]);
            inputLength --;
            }

        }
    }
}
