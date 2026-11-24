int x = 5;
int postIncrement = x++; // post-increment: x is used first, then incremented
int preIncrement = ++x; // pre-increment: x is incremented first, then used

Type theTypeOfInteger = typeof(int);
string nameOfVariable = nameof(x);
int howManyBytes = sizeof(int);
Console.WriteLine($"Initial value of x: {x}");
Console.WriteLine($"Value of postIncrement: {postIncrement}");
Console.WriteLine($"Value of preIncrement: {preIncrement}");
Console.WriteLine($"Type of integer: {theTypeOfInteger}");
Console.WriteLine($"Name of variable: {nameOfVariable}");
Console.WriteLine($"Size of integer: {howManyBytes} bytes");
bool p = true;
bool q = false;
 static void UpdateCustomerEmail(
      Customer? customer,
      string newEmail)
{
    if (customer is not null)
    {
        customer.Email = newEmail;
        Console.WriteLine("Email updated successfully.");
    }
    else
    {
        Console.WriteLine("Customer is null. Cannot update email.");
    }
}

//Ternary Operator
string result = x >3 ? "x is greater than 3" : "x is not greater than 3";

//Equivalent if-else statement
if (x > 3)
{
    result = "x is greater than 3";
}
else
{
    result = "x is not greater than 3";
}
Console.WriteLine($"Result: {result}");

int e = 11;
int f = 3;
WriteLine($"e = {e}, f = {f}");

double g = 11.0;

WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}"); // Division with double

//Null coalesing operator
string? name = GetAuthorName();

int maxLength = name?.Length ?? 30; // If name is null, maxLength will be 0

name ??= "Unknown Author"; // If name is null, assign "Unknown Author"
static string? GetAuthorName()
{
    return null; // Simulating a scenario where the author name is not available
}
WriteLine($"Author name: {name}, Max length: {maxLength}");

//Exploring logical operators
WriteLine($"AND | p | q ");
WriteLine($"p | {p & p,-5} | {p & q,-5} ");
WriteLine($"q | {q & p,-5} | {q & q,-5} ");
WriteLine();
WriteLine($"OR | p | q ");
WriteLine($"p | {p | p,-5} | {p | q,-5} ");
WriteLine($"q | {q | p,-5} | {q | q,-5} ");
WriteLine();
WriteLine($"XOR | p | q ");
WriteLine($"p | {p ^ p,-5} | {p ^ q,-5} ");
WriteLine($"q | {q ^ p,-5} | {q ^ q,-5} ");

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}

WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");

//&& Operator
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");

/*
    Learning when we used & operator the statement DoStuff() was executed for both p and q.
    But when we used && operator the statement DoStuff() was executed only for p and not for q.
    Reason being, the && operator is a short-circuiting operator. It evaluates the second operand only if the first operand is true. In the case of q (which is false), the second operand (DoStuff()) is not evaluated, hence it is not executed.
 */
//Null conditional operator


//Exploring bitwise and binary shift operators
WriteLine();
int xy = 10;
int yx = 3;
WriteLine($"Expression | Decimal | Binary");
WriteLine($"-------------------------------");
WriteLine($"x | {xy,7} | {xy:B8}");
WriteLine($"y | {yx,7} | {yx:B8}");
WriteLine($"x & y | {xy & yx,7} | {xy & yx:B8}");
WriteLine($"x | y | {xy | yx,7} | {xy | yx:B8}");
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
}





