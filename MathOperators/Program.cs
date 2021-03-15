using System;
namespace MathOperators
{
class Program
{
static void Main(string[] args)
{

char ch = 'a';
// Unicode representation
char c = '\u0061';
Console.WriteLine(ch);
Console.WriteLine(c);
// Escape character literal
Console.WriteLine("Hello\n\nWorld\t!");
Console.WriteLine(Math.Pow(6,2));
}
}
}