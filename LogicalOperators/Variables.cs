namespace LogicalOperators
{
class Variables
{
public static void Main(string[] args)
{
System.Console.WriteLine("Variable Casting!");
double numberDouble1 = 5.67;
int numberInt1 = (int)numberDouble1;
//numberInt = 5; casting will cut off all digits after comma without rounding
System.Console.WriteLine("numberDouble1: " + numberDouble1
+ ", numberInt1: " + numberInt1);
int numberInt2 = 4;
double numberDouble2 = numberInt2;
System.Console.WriteLine("numberInt2: " + numberInt2
+ ", numberDouble2: " + numberDouble2);
}
}
}