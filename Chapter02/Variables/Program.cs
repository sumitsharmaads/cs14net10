Console.WriteLine("Hello, World!");
char letter = 'A'; // Assigning literal characters.
char digit = '1';
char symbol = '$';
static char GetChar()
{ 
    return 'Z'; // Returning a literal character.
}
char userChoice = GetChar(); // Assigning from a fictitious function.

// Assigning a string returned from the string class constructor.
string horizontalLine = new('-', count: 74); // 74 hyphens.
// Assigning an emoji by converting from Unicode.
string grinningEmoji = char.ConvertFromUtf32(0x1F600);

/*
 * To output emojis at a command prompt on Windows, you must use Windows Terminal 
because Command Prompt does not support emojis, and set the output encoding of the 
console to use UTF-8, as shown in the following code:
 */
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(grinningEmoji);
Console.WriteLine($"""
    {horizontalLine} 
    Letter {letter} 
    Digit {digit}
    Symbol {symbol}
    userChoice {userChoice}
""");

//Verbatim string literal
string fullNameWithTab = "FirstName\tLastName";

/**
 * A verbatim string literal is prefixed with an @ symbol and can span multiple lines.
 * It does not recognize escape sequences, so the backslash character is treated as a 
 * literal character. To include a double quote in a verbatim string literal, use two 
 * double quotes.
 */
string pathName = @"C:\Users\Public\Documents\MyFile.txt";

//Raw String Literal
string xmlValue = """
    <book>
        <title>Programming C# 14</title>
        <author>Sumit Sharma</author>
    </book>
""";

//Raw Interpolated String Literal
var Person = new { FirstName = "Sumit", LastName = "Sharma", Age = 30 };
string jsonData = $$"""
    {
        "FirstName": "{{Person.FirstName}}",
        "LastName": "{{Person.LastName}}",
        "Age": {{{Person.Age}}}
    }
""";
Console.WriteLine(jsonData);

//Storing any type of Object
object height = 1.88;
object name = "Sumit Sharma";
Console.WriteLine($"{name} is {height} meters tall.");
//int length1 = name.length; /* This will cause a compile-time error because the 'object' type does not have a 'length' property. */
int length2 = ((string)name).Length; // Casting to string to access Length property.
Console.WriteLine($"{name} has {length2}");


#region dynamic type
dynamic something;
something = new[] { 1, 2, 3 }; // something is an int array}

something = 12; // something is an int

something = "Hello"; // something is a string

Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");
#endregion