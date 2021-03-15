using System;

namespace Assigm2
{
    class Program
    {
        static void Main(string[] args)
        {
        /*     //Assignment 2.3
            
            Console.Write("Input number one: ");
            double n1 = Double.Parse(Console.ReadLine());
            Console.Write("Input number two: ");
            double n2 = Double.Parse(Console.ReadLine());

            Console.Write("Enter the operation: ");
            char calc = Char.Parse(Console.ReadLine());

            switch (calc)
            {
            case '+':
            Console.WriteLine(n1 + "+" + n2 + "=" + (n1 + n2) );
            break;
            case '-':
            Console.WriteLine(n1 + "-" + n2 + "=" + (n1 - n2));
            break;            
            case '/':
            Console.WriteLine(n1 + ":" + n2 + "=" + (n1 / n2));
            break;
            case '%':
            Console.WriteLine(n1 + ":" + n2 + "=" + "remaind is "+ (n1 % n2));
            break;
            case '*':
            Console.WriteLine(n1 + "*" + n2 + "=" + (n1 * n2));
            break;
            case 'p':
            Console.WriteLine(n1 + " and " + n2);
            break;
            case 'b':
            Console.WriteLine("Bigger is " + Math.Max(n1,n2));
            break;
            case 's':
            Console.WriteLine("Smaller is " + Math.Min(n1,n2));
            break;
            default: //else
            Console.WriteLine("Error");
            break;
            } 
  */
            

            /*  //Assignment 2.2

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
            break; */
            //}

            //rounding
            //double a = 1.333333338888;
            //double b = Math.Round(a);
            //Console.WriteLine(b);

           /*  int[] numbers = {10, 100, 20, 220, 500, 650};
            for (int i = 0; i < 5; i += 2)
            {
                Console.WriteLine(numbers[i]*2/5);}  */  


                //Assignment 3
            byte[] grades = new byte[10];
            

            for (int i = 0; i < grades.Length; i++)
            {Console.Write("Please input grades: ");
            int userInput = Int32.Parse(Console.ReadLine());
            {
                if (userInput >= 0 && userInput <= 10)                
                {grades[i] = (byte)userInput;}
                else            
                {
                    Console.WriteLine("Please try again. The grade must be in range 0 to 10.");
                    i--;  //because in this case i goes to next i and leaves 0 instead of wrong value
                }
                
            }}
            Console.Write("The list of grades: " );
            foreach (byte grade in grades)
            {Console.Write (grade + ", ");}
            Console.WriteLine();  

            int failed = 0;
            int getA = 0;
            foreach (var item in grades)
            {
                if (item < 4)
                {failed ++;}
                if (item == 10)
                {getA ++;}
                
            }
            Console.WriteLine("Failed " + failed);
            Console.WriteLine("The grade 'A' got  " + getA);

            
            int [] histogram = new int [11];
            foreach (byte grade in grades)
            {
            histogram[grade]++;
            }
            for (int i = 0; i < histogram.Length; i++)
            {
              Console.WriteLine(histogram[i] + " students with the grade " + i + ".");   
            }
        }
    }
}
