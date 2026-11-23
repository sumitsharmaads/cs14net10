// An unsigned integer is a positive whole number or 0.
uint naturalNumber = 23;

// An integer is a negative or positive whole number or 0.
int integerNumber = -23;

// A float is a single-precision floating-point number.
// The F or f suffix makes the value a float literal.
// The suffix is required to compile.
float realNumber = 2.3F;

// A double is a double-precision floating-point number.
// double is the default for a number value with a decimal point.
double anotherRealNumber = 2.3;

//The readibility and useability of code is improved when you use the correct type for the data you are working with.
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

//Output of variables
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{decimalNotation:X}");

//number size
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range { int.MinValue:N0} to {int.MaxValue:N0}.");

//Writing with Decimals
decimal a = 0.1M;
decimal b = 0.2M;
if (a + b == 0.3M)
{
    Console.WriteLine($"{a} + {b} equals 0.3: decimal");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal 0.3: decimal");
}

double c = 0.1;
double d = 0.2;
if (c + d == 0.3)
{
    Console.WriteLine($"{c} + {d} equals 0.3 : double");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal 0.3 : double");
}

float e = 0.1F;
float f = 0.2F;
if (e + f == 0.3F)
{
    Console.WriteLine($"{e} + {f} equals 0.3 : float");
}
else
{
    Console.WriteLine($"{e} + {f} does NOT equal 0.3 : float");
}

#region special float and double numbers
Console.WriteLine($"Double eclipse: {double.Epsilon}");
Console.WriteLine($"Double eclipse to 324 decimal places: {double.Epsilon:N324}");
Console.WriteLine($"Double eclipse to 330 decimal places: {double.Epsilon:N330}");

const int col1 = 37;
const int col2 = 6;
string line = new string('-', col1 + col2 + 3);
Console.WriteLine(line);
Console.WriteLine($"{"Expression",-col1} | {"Value",col2}");
Console.WriteLine(line);
Console.WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}");
Console.WriteLine($"{"double.PositiveInfinity",-col1} | {double.
PositiveInfinity,col2}");
#endregion


#region In .Net 7 few new data types introdcuded with Hlaf, Int128, UInt128, BFloat16, and nint/nuint.
//using without the unsafe block it will throw an error "Cannot take the size of a managed type 'Half' unless it is boxed or wrapped in an unsafe context"
//Console.WriteLine($"Half uses {sizeof(Half)} bytes");

//To allow unsafe code we are required to enable unsafe code in the project file. In the .csproj file, add the following line inside the <PropertyGroup> element: <AllowUnsafeBlocks>true</AllowUnsafeBlocks>

unsafe
{ 
 Console.WriteLine($"Half uses {sizeof(Half)} bytes");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes");
    Console.WriteLine($"UInt128 uses {sizeof(UInt128)} bytes");
    Console.WriteLine($"nint uses {sizeof(nint)} bytes");
    Console.WriteLine($"nuint uses {sizeof(nuint)} bytes");{ }
}
#endregion