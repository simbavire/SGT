using System;

namespace Asignments
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
/*             int variable1 = 127;
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
                else { Console.WriteLine("Sorry, the time value is wrong"); } */


           /* //Assinment 1.3.
            Console.WriteLine("Please write the day: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please write the month: ");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please write the year: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please select the date formatting. 1-YYYY/MM/DD; 2 - YYYY.MM.DD: ");
            int sel = Int32.Parse(Console.ReadLine());

            if (((y>0 && y<3000) && (m>0 && m<=12)) && 
            (((d>0 && d<=31) && (m == 1 || m==3 || m==5 || m==7|| m==8 || m==10 || m==12)) ||
            ((d>0 && d<=30) && (m == 4 || m==6 || m==9 || m==11))||
            ((d>0 && d<=28) && (m == 2)))){
                if (sel == 1)
                {Console.WriteLine(y.ToString("0000") + "/" + m.ToString("00") + "/" + d.ToString("00"));}
                if (sel == 2) 
                {Console.WriteLine(y.ToString("0000") + "." + m.ToString("00") + "." + d.ToString("00"));}}
            
            else
            {Console.WriteLine("Invalid input");} */



            /* //Assinment 1.4.
            Console.WriteLine("The day number is: ");
            int dayNum = Int32.Parse(Console.ReadLine());
            
            if (dayNum > 0 && dayNum <= 31){Console.WriteLine("It is: January");}
            else if (dayNum > 31 && dayNum <= 59){Console.WriteLine("It is: February");} //or dayNum<=31+28 - do not to write sum
            else if (dayNum > 59 && dayNum <= 90){Console.WriteLine("It is: March");} // or else if (day <= (sum+=march)) {Console.WriteLine("It is March!");}
            else if (dayNum > 90 && dayNum <= 120){Console.WriteLine("It is: April");}
            else if (dayNum > 120 && dayNum <= 151){Console.WriteLine("It is: May");}
            else if (dayNum > 151 && dayNum <= 181){Console.WriteLine("It is: June");}
            else if (dayNum > 181 && dayNum <= 212){Console.WriteLine("It is: July");}
            else if (dayNum > 212 && dayNum <= 243){Console.WriteLine("It is: August");}
            else if (dayNum > 243 && dayNum <= 273){Console.WriteLine("It is: September");}
            else if (dayNum > 273 && dayNum <= 304){Console.WriteLine("It is: October");}
            else if (dayNum > 304 && dayNum <= 334){Console.WriteLine("It is: November");}
            else if (dayNum > 334 && dayNum <= 365){Console.WriteLine("It is: December");}
            else
            {Console.WriteLine("Invalid input");}
 */
            //Asignment 1.5
            
            /* Console.WriteLine("Input your working hours in day: ");
            int workingHoursInDay = Int32.Parse(Console.ReadLine());
            int hourlyRate = 10;
            int hourlyRateLarger = 15;

            if (workingHoursInDay > 0 && workingHoursInDay <= 8){
                int salary = workingHoursInDay * hourlyRate;
                Console.WriteLine("Your salary is " + salary + " EUR.");
            }
            else if (workingHoursInDay >= 8 && workingHoursInDay <= 24){
                int largerSalary = 8*hourlyRate + (workingHoursInDay - 8) * hourlyRateLarger;
                Console.WriteLine("Your salary is " + largerSalary + " EUR.");
                
            }
            else
            {
               Console.WriteLine("Sorry, try again to input valid value."); 
            } */

            /* //This can be solved  also like:
            Console.Write("How many hours were worked: ");
            int workedHoursInDay = Int32.Parse(Console.ReadLine());

            if (workedHoursInDay < 0 || workedHoursInDay > 24)
            {
                Console.WriteLine("You can't work that many hours a day!");
            }
            else
            {
                int salary = Math.Min(workedHoursInDay, 8) * 10; // (hours up until 8h) * 10
                salary += Math.Max(workedHoursInDay - 8, 0) * 15; // (hours more than 8h) * 15

                Console.WriteLine("The salary is " + salary.ToString("0.00") + " EUR.");
            } */
            //Assigment 2.1
/* 
            Console.Write("What is a day?: ");
            int dayInWeek = Int32.Parse(Console.ReadLine());
            

            switch (dayInWeek)
            {case 1: //if (day ==1)
            case 2:
            case 3:
            case 4:
            case 5:
            Console.WriteLine("This is workday.");
            break;
            case 6:
            case 7:
            Console.WriteLine("This is holiday.");
            break;
            default: //else
            Console.WriteLine("Error");
            break;
            } */


            //Assignment 2.2

            Console.Write("What is a grade: ");
            char grade = Char.Parse(Console.ReadLine().ToUpper());
            

            switch (grade)
            {
            case 'A':
            case 'B':
            Console.WriteLine("Perfect! You are clever!");
            break;            
            case 'C':
            Console.WriteLine("Thats good.");
            break;
            case 'D':
            case 'E':
            Console.WriteLine("Its not good.");
            break;
            case 'F':
            Console.WriteLine("Thats a fail.");
            break;
            default: //else
            Console.WriteLine("Error");
            break;
            }

            
        }
    }
}}

