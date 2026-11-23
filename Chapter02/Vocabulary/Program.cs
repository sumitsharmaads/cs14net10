using System.Reflection;

Console.WriteLine("Hello, World!");
//commenet inline comment can be used
/*
 * This is a multi-line comment
 */

#region Write a simple program to add two numbers
var x = 10;
var y = 20;
var z = x + y;
#endregion


Console.WriteLine($"Computer named {Env.MachineName} says \"Not.\"");

// Outputs a formatted number and date and the current line terminator.
Console.WriteLine(
 "Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);


Assembly ? myApp = Assembly.GetEntryAssembly();
// If the previous line returned nothing then end the app.
if (myApp is null) return;

foreach(AssemblyName name in myApp.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    // Declare a variable to count the number of methods.
    int methodCount = 0;

    // Loop through all the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Add up the counts of all the methods.
        methodCount += t.GetMethods().Length;
    }

    Console.WriteLine("{0:N0} type with {1:N0} methods in {2} assembly", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: name.Name);
}

double heightInMeters = 1.88;
Console.WriteLine($"The variable {nameof(heightInMeters)} has a value of {heightInMeters} meters.");