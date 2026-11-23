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