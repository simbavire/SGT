using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            //int [] newArr = {5, 3, 7, 6, 2, 8};
            //for (int i = 0; i < newArr.Length; i++)
            //{Console.WriteLine(newArr[i]);}



           //Assignment 2
           int [] newArr2 = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};
           double sum = 0;
           for (int i = 0; i < newArr2.Length; i++)
           {sum += newArr2 [i];}
           double avg = sum / newArr2.Length;
           Console.WriteLine("The average is " + avg);
           

        }
    }
}
