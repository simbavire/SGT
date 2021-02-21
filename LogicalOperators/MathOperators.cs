using System;
namespace LogicalOperators
{
class MathOperators
{
static void Main(string[] args)
{
int x = 15, y = 10;
Console.WriteLine(x%y);
bool result = x==y;
bool result2 = x!=y;
Console.WriteLine(result);
// Max and Min methods
Console.WriteLine(Math.Max(3, 7)); // will print max value, that is 7
Console.WriteLine(Math.Min(3, 7)); // will print max value, that is 3
Console.WriteLine(Math.Min(x, y));
// Absolute and Round methods
Console.WriteLine(Math.Abs(-5.9)); // will print absolute value, that is 5.9
Console.WriteLine(Math.Round(-5.9)); // will print rounded value, that is -6
//Try other methods from the prevous slide on your own
Console.WriteLine(Math.Sqrt(156));
Console.WriteLine(x++);
Console.WriteLine("x now is "+x);
Console.WriteLine(++x);
Console.WriteLine("x now is "+x);
Console.WriteLine(+x); 
Console.WriteLine("x now is "+x);
Console.WriteLine(x%y);
Console.WriteLine("Press Enter Key to Exit..");
Console.ReadLine();
}
}
}