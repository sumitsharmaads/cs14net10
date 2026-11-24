//Formatting using numbered positional arguments
using System.Globalization;

//Ser current Cultivated culture to US English so that all reader see the same output as shown in the book
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: numberOfApples * pricePerApple);

string formatted = string.Format(

    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: numberOfApples * pricePerApple);
Console.WriteLine(formatted);

// Four or more parameter values cannot use named arguments.
Console.WriteLine(
 "{0} {1} lived in {2} and worked in the {3} team at {4}.",
 "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

Console.WriteLine($"{numberOfApples} apples cost {pricePerApple
 * numberOfApples:C}");

//outputting a value using multiple formats
decimal value = 1234.335M;
Console.WriteLine("{0:C}, percentage: {0:0.0%}", value);

Console.WriteLine("The date is {0:D} and the time is {0:T}.", DateTime.Now);

Console.WriteLine("The group separator is {0:0,0.00}.", value);

#region
string ? name = Console.ReadLine();
string ? age = Console.ReadLine();
Console.WriteLine($"Hello {name}, you look good for {age}.");
#endregion