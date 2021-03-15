using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //           int number1,number2;
            //Console.Write("\n\n");
            //Console.Write("Check whether two integers are equal or not:\n");
            //Console.Write("-------------------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Input the 1st number: ");
            //number1= Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the 2nd number: ");
            //number2= Convert.ToInt32(Console.ReadLine());
            //if (number1 == number2)
            //Console.WriteLine($"{number1} and {number2} are equal.\n");
            //else
            //Console.WriteLine("{0} and {1} are not equal.\n",number1,number2);
            int variable1 = 127;
            int variable2 = -11;
            int maxVariable = Math.Max(variable1, variable2);
            Console.WriteLine($"The largest variable is {maxVariable}");
            int minVariable = Math.Min(variable1, variable2);
            Console.WriteLine($"The smallest variable is {minVariable}");
            if (minVariable == maxVariable)
            {
                Console.WriteLine("Both variables are equal.");
            }
            else
            {
                Console.WriteLine("Both variables are not equal.");
            }

            Console.WriteLine(Math.Max(variable1, variable2) + " is the largest");
            Console.WriteLine(Math.Min(variable1, variable2) + " is the smallest");
            if (variable1 % 2 == 0)
            {
                Console.WriteLine($"{variable1} is even.");
            }
            else
            {
                Console.WriteLine($"{variable1} is odd.");
            }

            if (variable2 % 2 == 0)
            {
                Console.WriteLine($"{variable2} is even.");
            }
            else
            {
                Console.WriteLine($"{variable2} is odd.");
            }

            if (variable1 < 0)
            {
                Console.WriteLine($"{variable1} is negative.");
            }
            if (variable2 < 0)
            {
                Console.WriteLine($"{variable2} is negative.");
            }


            if (variable1 > 0)
            {
                Console.WriteLine($"{variable1} is positive.");
            }
            if (variable2 > 0)
            {
                Console.WriteLine($"{variable2} is positive.");
            }


            if (variable1 < 100)
            {
                Console.WriteLine($"{variable1} is less than 100.");
            }
            if (variable2 < 100)
            {
                Console.WriteLine($"{variable2} is less than 100.");
            }


            int time = -2;
            if (time >= 0 || time < 24)
            {
                if (time <= 12)
                {
                    Console.WriteLine("Good morning Sunshine!");
                }
                else if (time >= 13 && time <= 19)
                {
                    Console.WriteLine("Good afternoon, Work Hard!");
                }
                else if (time >= 20 && time <= 24)
                {
                    Console.WriteLine("Good evening, take some rest!");
                }}
                else { Console.WriteLine("Sorry, the time value is wrong"); }


            int d=12, m=12, y=2021;
            if d
            day > 0 && <= 31;
            //month > 0 && <=12;
            //year > 0;


            }
        }
    }




