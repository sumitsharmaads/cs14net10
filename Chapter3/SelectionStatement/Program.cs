using System.Runtime;
using System.Threading.Tasks.Dataflow;

static string GetScore(int score)
{
    if (score < 50)
    {
        return "Fail";
    }
    return "Pass";
}

object o = "5";
int j = 4;

if (o is int i)
{
    Console.WriteLine($"{i} x {j} = {i * j}");
}
else
{
    Console.WriteLine("o is not an int so it cannot multiply!");
}

int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2: 
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}

WriteLine("After end of Switch");
A_label:
WriteLine($"After A_label");

var animals = new Animal?[]
{
    new Cat { Name = "Karen", Born = new(year: 2022, month: 8,
 day: 23), Legs = 4, IsDomestic = true },
 null,
 new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6,
 day: 12) },
 new Spider { Name = "Sid Vicious", Born = DateTime.Today,
 IsVenomous = true},
 new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

//Switch condition on Object
foreach (Animal ? animal in animals)
{
    string message;
    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;
        case Cat WildCat when WildCat.IsDomestic == false:
            message = $"The non-domestic cat is named {WildCat.Name}.";
            break;
        case Cat cat:
            message = $"The cat named {cat.Name} is domestic.";
            break;
        default:
            message = $"{animal.Name} is a {animal.GetType().Name}.";
            break;
        case Spider spider when spider.IsVenomous:
            message = $"The {spider.Name} spider is venomous. Run!";
            break;
        case null:
            message = "The animal is null.";
            break;
    }
    string message2 = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4 =>
            $"The cat named {fourLeggedCat.Name} has four legs.",
        Cat WildCat when WildCat.IsDomestic == false =>
            $"The non-domestic cat is named {WildCat.Name}.",
        Cat cat =>
            $"The cat named {cat.Name} is domestic.",
        Spider spider when spider.IsVenomous =>
            $"The {spider.Name} spider is venomous. Run!",
        null => "The animal is null.",
        _ => $"{animal.Name} is a {animal.GetType().Name}."
    };
    WriteLine(message);
    WriteLine(message2);
}
