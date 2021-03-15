using System;

namespace loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            //int[] newArr = { 5, 3, 7, 6, 2, 8 };
            //for (int i = 0; i < newArr.Length; i++)
            //{Console.WriteLine(newArr[i]);}
            //foreach (int i in newArr) 
            //{Console.WriteLine(i);}
            //int i = 0;
            /* while ( i < newArr.Length)
            {Console.WriteLine(newArr[i]);
            i++;} */

            /* do
            {
                Console.WriteLine(newArr[i]);
                i++;
            }
            while (i < newArr.Length); */




            //Assignment 2
            int[] newArr2 = { 10, 4, -4, 7, 0, 9, 1, 3, 7, -5 };
            /* double sum = 0;
            for (int i = 0; i < newArr2.Length; i++)
            { sum += newArr2[i]; }
            double avg = sum / newArr2.Length;
            Console.WriteLine("The average is " + avg); */

            /* for (int i = 0; i < newArr2.Length; i++)  //foreach
            {if (newArr2 [i] <0)
            {Console.WriteLine("The negative is " + newArr2 [i]);}} */

            /*  int avgCount = 0;
             double avg = 3.2;
             foreach (int element in newArr2)
             {
                 if (element < avg)
                 {
                     avgCount++;
                 }
             }
             Console.WriteLine("There are " + avgCount + "less values than average."); */


            /*  int oddCount = 0;
             for (int i = 0; i < newArr2.Length; i++)  //foreach
             {
                 if (newArr2[i] % 2 != 0)
                 {
                     Console.WriteLine("The odd is " + newArr2[i]);
                     oddCount++;
                 }
             }
             Console.WriteLine("There are " + oddCount + " odds."); */

            /*  for (int i = 0; i < newArr2.Length; i++)
             {
                 for (int j = i+1; j < newArr2.Length; j++)
                     if (newArr2[i] == newArr2[j])
                     { Console.WriteLine("Similar are " + newArr2[i] + " at indexes " + i + " and " + j.); }
             }

             for (int i = 0; i < newArr2.Length; i += 2)
             { Console.WriteLine("Each second element is " + newArr2[i]); } */


            //Assignment 3
            byte[] grades = new byte[10];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Please input grades: ");
                int userInput = Int32.Parse(Console.ReadLine());
                grades[i] = (byte)userInput;
                if (userInput < 0 || userInput > 10)
                {
                    Console.WriteLine("Please try again. The grade must be in range 0 to 10.");
                }

            }
            Console.Write("The list of grades: ");
            foreach (byte grade in grades)
            { Console.Write(grade + ", "); }
            Console.WriteLine();

        }
    }
}
