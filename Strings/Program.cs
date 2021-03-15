using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string txt = "Raivis Reinfelds";
            Console.WriteLine(txt.ToUpper());   
            Console.WriteLine(txt.ToLower()); 
            string firstName = "Janis";
            string lastName = "Berzins"; */

//string name = firstName + " " +  lastName;
//Console.WriteLine(name);
            /* string name = string.Concat(firstName,  lastName);
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
            Console.WriteLine($"Length of the string is : {howManyLetters}");
            int inputLength = userInput.Length - 1;
            Console.Write("The characters of the string in reverse are:\n");
            while (inputLength >= 0)
            {
            Console.Write("{0}", userInput[inputLength]);
            inputLength --;
            }

            for (int i = userInput.Length-1; i >= 0; i --){
                Console.Write ($"{userInput[i]}");
            }
            Console.WriteLine();
            string [] words = userInput.Split (" ");
            Console.WriteLine(words.Length); */

            string [] words = {"Computer", "Plate", "Chair", "Girl", "Boy", "Cat", "Dog", "Shirt", "Determination"};
            int startsWithC = 0, endsWithE = 0, hasLength5 = 0; containsTe = 0; 
            foreach (string item in words)
            {
                
                if (item.StartsWith ("C")){
                    startsWithC ++;

                if (item.Contains ("te")){
                    containsTe++;
                }
                
                }
                
            }
            Console.WriteLine($"Starts with C : {startsWithC}");


            //ASS3

            string sentence = "Climb mountains not so the world can see you, but so you can see the world";
        }
    }
}
