using System;
namespace LogicalOperators
{
    class branching
    { //our main class
      // Main method
        public static void Main(String[] args)
        {
            {

                char grade = 'F';

                switch (grade)
                {
                    case 'F':
                        Console.WriteLine("Please work on it - you are failing.");
                        break;
                    case 'E':
                    case 'D':
                        Console.WriteLine("You are not failing, but please work on it.");
                        break;
                    default:
                        Console.WriteLine("You are fine.");
                        break;
                }


            }
        }
    }
}