using System.Collections;

int x = 0;
while (x < 10)
{
    WriteLine($"The value of x is: {x}");
    x++;
};

//Looping with for Each satement
List<string> names = ["John", "Jane", "Jack", "Jill"];
foreach(string name in names)
{
    WriteLine($"The name is: {name}");
};

IEnumerator e = names.GetEnumerator();

while(e.MoveNext())
{
    WriteLine($"The name is: {e.Current}");
};
