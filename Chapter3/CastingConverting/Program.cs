using static System.Convert;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

//Casting Implicit and Explicit Conversions
int a = 10;
double b = a; // Implicit conversion from int to double
Console.WriteLine($"a is {a}, b is {b}");

double c = 9.78;
int d = (int)c; //Explicit conversion from double to int
Console.WriteLine($"c is {c}, d is {d}");

long e = 10;
int f = (int)e; //Explicit conversion from long to int
Console.WriteLine($"e is {e:N0}, f is {f:N0}"); 

double g = 9.78;
int h = System.Convert.ToInt32(g); // Explicit conversion from double to int

int totalvalue = int.Parse("100"); // Explicit conversion from string to int")
DateTime birthDate = DateTime.Parse("4 June 1998"); // Explicit conversion from string to DateTime

Console.Write("How many eggs are there? ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int count))
{
    Console.WriteLine($"There are {count} eggs.");
}
else
{
    Console.WriteLine("I could not parse the input.");
}
