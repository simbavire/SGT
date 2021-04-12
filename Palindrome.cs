using System;
using System.Text.RegularExpressions;

namespace SGT_DotNet5_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex nonLetters = new Regex("[^A-Za-z]"); //takes away all nonletters

            string[] inputs = {
                "Mom",
                "Was it a car or a cat I saw?",
                "Madam, in Eden, I’m Adam.",
                "Yo, banana boy!",
                "Failure condition."
            };

            foreach (string input in inputs)
            {
                bool isPalindrome = true;
                string lowerInput = nonLetters.Replace(input, "").ToLower(); //all letters lowercase, for comparing
                for (int i = 0; i < lowerInput.Length / 2; i++) //the loop goes to the middle
                {
                    int leftIndex = 0 + i;  //starts from begining
                    char left = lowerInput[leftIndex];

                    int rightIndex = (lowerInput.Length - 1) - i; //starts from end and goes to middle
                    char right = lowerInput[rightIndex];

                    if (left != right)
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine($"{input} : {isPalindrome}");
            }
        }
    }
}
