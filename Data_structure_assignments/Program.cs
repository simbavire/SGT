using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_structure_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Assignment No.1 (1h)
            Write a program for actions with ArrayList. Please take a look at the documentation of the
            ArrayList class:
            https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-5.0.
            ● Take a look to Assignment No.1 from the String materials.
            a. Create a String array with following values: “Computer”, “Plate”, “Chair”, “Girl”,
            “Boy”, “Cat”, “Dog”, “Shirt”, “Determination”;
            b. Find out how many values are starting with ‘C’;
            c. Find out how many values are ending with “e”;
            d. Find out how many values are with length 5;
            e. Find out how many values consist of the character “e”;
            f. Find out is there any element which consists of the subString “te”;
            g. * Calculate a histogram of values related to length of value.
            ● Edit the previous written code to use ArrayList class for the value storing.
            ● Sort all ArrayList values in ascending order by the first letter. You can choose any of the
            sorting algorithms, but the realization should be Your own. Some sorting algorithms’
            visualizations here: https://www.cs.usfca.edu/~galles/visualization/ComparisonSort.html */

         // a. Create a String array with following values:
            string[] words = {
                "Computer",
                "Plate",
                "Chair",
                "Girl",
                "Boy",
                "Cat",
                "Dog",
                "Shirt",
                "Determination"
            };

            // b. Find out how many values are starting with ‘C’;
            int countStartingWithC = 0;
            foreach (string word in words)
            {
                if (word.StartsWith('C'))
                {
                    countStartingWithC++;
                }
            }
            Console.WriteLine($"{countStartingWithC} word(s) start with 'C'.");

            // c. Find out how many values are ending with “e”;
            int countEndingWithE = 0;
            foreach (string word in words)
            {
                if (word.EndsWith('e'))
                {
                    countEndingWithE++;
                }
            }
            Console.WriteLine($"{countEndingWithE} word(s) end with 'e'.");

            // d. Find out how many values are with length 5;
            int countLength5 = 0;
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    countLength5++;
                }
            }
            Console.WriteLine($"{countLength5} word(s) have a length of 5.");

            // e. Find out how many values consist of the character “e”;
            int countContainsE = 0;
            foreach (string word in words)
            {
                if (word.Contains('e'))
                {
                    countContainsE++;
                }
            }
            Console.WriteLine($"{countContainsE} word(s) contain character 'e'.");

            // f. Find out is there any element which consists of the subString “te”;
            foreach (string word in words)
            {
                if (word.Contains("te"))
                {
                    Console.WriteLine($"'{word}' contains substring 'te'.");
                }
            }

            // g. * Calculate a histogram of values related to length of value.
            int longestLength = 0;
            foreach (string word in words)
            {
                if (word.Length > longestLength)
                {
                    longestLength = word.Length;
                }
            }
            int[] histogram = new int[longestLength + 1];
            foreach (string word in words)
            {
                histogram[word.Length]++;
            }
            for (int length = 1; length <= longestLength; length++)
            {
                int count = histogram[length];
                if (count > 0)
                {
                    Console.WriteLine($"{count} word(s) are of length {length}.");
                }
            }
            ArrayList words2 = new ArrayList();
            words2.Add("Plate");
            words2.Add("Computer");
            words2.Add("Chair");
            words2.Add("Girl");
            words2.Add("Boy");
            words2.Add("Cat");
            words2.Add("Dog");
            words2.Add("Shirt");
            words2.Add("Determination");
            words2.Sort();
            foreach (string word in words2)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.WriteLine();

            //Sorting code
            // a. Create a String array with following values:
            string[] array = {
                "Computer",
                "Plate",
                "Chair",
                "Girl",
                "Boy",
                "Cat",
                "Dog",
                "Shirt",
                "Determination"
            };

            // use ArrayList class for the value storing
            ArrayList words = new ArrayList();
            foreach (string word in array)
            {
                words.Add(word);
            }

            // Sort all ArrayList values in ascending order by the first letter
            foreach (string word in words)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.WriteLine();
            words = MergeSort(words);
            foreach (string word in words)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.WriteLine();

            // b. Find out how many values are starting with ‘C’;
            int countStartingWithC = 0;
            foreach (string word in words)
            {
                if (word.StartsWith('C'))
                {
                    countStartingWithC++;
                }
            }
            Console.WriteLine($"{countStartingWithC} word(s) start with 'C'.");

            // c. Find out how many values are ending with “e”;
            int countEndingWithE = 0;
            foreach (string word in words)
            {
                if (word.EndsWith('e'))
                {
                    countEndingWithE++;
                }
            }
            Console.WriteLine($"{countEndingWithE} word(s) end with 'e'.");

            // d. Find out how many values are with length 5;
            int countLength5 = 0;
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    countLength5++;
                }
            }
            Console.WriteLine($"{countLength5} word(s) have a length of 5.");

            // e. Find out how many values consist of the character “e”;
            int countContainsE = 0;
            foreach (string word in words)
            {
                if (word.Contains('e'))
                {
                    countContainsE++;
                }
            }
            Console.WriteLine($"{countContainsE} word(s) contain character 'e'.");

            // f. Find out is there any element which consists of the subString “te”;
            foreach (string word in words)
            {
                if (word.Contains("te"))
                {
                    Console.WriteLine($"'{word}' contains substring 'te'.");
                }
            }

            // g. * Calculate a histogram of values related to length of value.
            int longestLength = 0;
            foreach (string word in words)
            {
                if (word.Length > longestLength)
                {
                    longestLength = word.Length;
                }
            }
            int[] histogram = new int[longestLength + 1];
            foreach (string word in words)
            {
                histogram[word.Length]++;
            }
            for (int length = 1; length <= longestLength; length++)
            {
                int count = histogram[length];
                if (count > 0)
                {
                    Console.WriteLine($"{count} word(s) are of length {length}.");
                }
            }
        }

        //Sorting
/* 
        static ArrayList MergeSort(ArrayList original)
        {
            if (original.Count <= 1)
            {
                return original;
            }

            ArrayList left = new ArrayList();
            ArrayList right = new ArrayList();

            for (int i = 0; i < original.Count; i++)
            {
                object value = original[i];
                if (i < original.Count / 2)
                {
                    left.Add(value);
                }
                else
                {
                    right.Add(value);
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);

            ArrayList result = new ArrayList();

            while (left.Count > 0 && right.Count > 0)
            {
                string leftValue = (string)left[0];
                string rightValue = (string)right[0];

                if (leftValue[0] < rightValue[0])
                {
                    result.Add(leftValue);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(rightValue);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result; */
        }
    }
}
