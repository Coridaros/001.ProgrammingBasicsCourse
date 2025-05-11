//Conditional statements advanced - exercise, Task 005
//11.05.2025, 16:56

double budjet = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string dest = string.Empty;
string type = string.Empty;
double price = 0.0;

if (budjet <= 100)
{
    dest = "Bulgaria";

    if (season == "summer")
    {
        price = budjet * 0.30;
        type = "Camp";
    }
    else if (season == "winter")
    {
        price = budjet * 0.70;
        type = "Hotel";
    }
}
else if (budjet > 100 && budjet <= 1000)
{
    dest = "Balkans";

    if (season == "summer")
    {
        price = budjet * 0.40;
        type = "Camp";
    }
    else if (season == "winter")
    {
        price = budjet * 0.80;
        type = "Hotel";
    }
}
else if (budjet > 1000)
{
    dest = "Europe";
    price = budjet * 0.90;
    type = "Hotel";
}

Console.WriteLine($"Somewhere in {dest}");
Console.WriteLine($"{type} - {price:F2}");