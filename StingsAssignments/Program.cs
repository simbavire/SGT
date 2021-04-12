using System;
using System.Text.RegularExpressions;

namespace StingsAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Input text: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Your text is: {userInput}.");
            Console.WriteLine($"The length of sentence is {userInput.Length} letters.");
            for (int i = userInput.Length-1; i >= 0; i-- ){
                Console.Write(userInput[i]);
            }
            Console.WriteLine();
            Console.WriteLine(userInput.Split(" ").Length); */
            
            
 
            //ASS2
           /*  string [] words = {"Computer", "Plate", "Chair", "Girl", "Boy", "Cat", "Dog", "Shirt", "Determination"};
            
            int beginsWithC = 0; 
            int endsWithE = 0; 
            int length5 = 0;
            int consistsE = 0;
            int consistsTe = 0;
            int maxLength = 0;
            

            foreach (string item in words)
            {
                if (item.StartsWith("C"))
                {
                    beginsWithC++;
                }
            
                if (item.EndsWith("e"))
                {
                     endsWithE++;
                }
                
                if (item.Length > maxLength){
                    maxLength = item.Length;
                }
            }
                
            Console.WriteLine("begins with c: " + beginsWithC + " ends with e: " + endsWithE);

            int [] histogram = new int [maxLength +1];
            foreach (string item in words)
            {
                histogram[item.Length]++;
            }
            for (int wordLenght = 1; wordLenght < histogram.Length; wordLenght++)
            {
                Console.WriteLine($"{histogram[wordLenght]} words with lenght {wordLenght}. ");
            } */

            //aSS3
/* 
            string ass3 = "Climb mountains not so the world can see you, but so you can see the world";
            Console.WriteLine("how many words are in the sentence: " + ass3.Split(" ").Length);
            string [] woords = ass3.Split(" ");
            int wordThe = 0;
            int letterS = 0;
            foreach (string word in woords)
            {
                if (word.Equals("the"))
                {
                    wordThe ++;
                }
                if (word.Contains("s"))
                {
                    letterS ++;
                }
            }
            Console.WriteLine("how many “the” words are in the sentence: " + wordThe);
            Console.WriteLine("how many words consists 's': " + letterS);

            
            for (int i = 0; i < woords.Length; i++)
        {
            for (int j = i+1; j < woords.Length; j++)
            {
                string wordA = woords[i];
                string wordB = woords[j];
                if (wordA.Equals(wordB))
                {
                    
                    Console.WriteLine($"The word {wordA} is repeated");
                }
            }
        }
        Console.WriteLine(ass3.Replace("you", "You")); */

        //ass4

         // ● Create a String variable `name` with the value “John”
            string name = "John";

            // create a regex pattern for that (only letters are allowed).
            Regex nameRegex = new Regex("^[A-Za-z]+$");
            bool nameIsValid = nameRegex.IsMatch(name);
            Console.WriteLine("Name is valid: " + nameIsValid);

            // ● Create a String variable `username` with the value “s20surname”
            string username = "s20surname";
            // create a regex pattern for that (the first is a letter,
            // after that 2 digits are allowed and after that unlimited letters are allowed).
            Console.WriteLine("Username is valid: " + Regex.IsMatch(username, "^[A-Za-z]([0-9]{2})?[A-Za-z]*$"));

            // ● Create a String variable `personCodeOfLatvian` with the value “121200-11311”
            string personCodeOfLatvian = "121200-11311";
            // create a regex pattern for that (6 digits, after that - sign, after that 5 digits).
            Regex personCodeRegex = new Regex("^([0-9]{6})-([0-9]{5})$");
            Match match = personCodeRegex.Match(personCodeOfLatvian);
            if (!match.Success)
            {
                Console.WriteLine("Person code is valid: False");
            }
            else
            {
                int[] pk = new int[11];
                for (int i = 0; i < pk.Length; i++)
                {
                    pk[i] = personCodeOfLatvian[i < 6 ? i : (i + 1)] - '0';
                }

                int day = pk[0] * 10 + pk[1];
                int month = pk[2] * 10 + pk[3];
                int century = (18 + pk[6]) * 100;
                int year = century + pk[4] * 10 + pk[5];

                if (day == 32)
                {
                    Console.WriteLine("New series personal code");
                }
                else
                {
                    // TODO Check if day+month+year are reasonable.
                }

                int checksum = (1101 - (1 * pk[0] + 6 * pk[1] + 3 * pk[2] + 7 * pk[3] +
                    9 * pk[4] + 10 * pk[5] + 5 * pk[6] + 8 * pk[7] + 4 * pk[8] + 2 * pk[9])) % 11;

                Console.WriteLine("Person code is valid: " + (checksum == pk[10]));
            }
        }

    
        }
    }

