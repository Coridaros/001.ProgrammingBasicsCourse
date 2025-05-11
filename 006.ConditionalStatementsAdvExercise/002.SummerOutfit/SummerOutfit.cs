//Conditional statements advanced - exercise, Task 002
//11.05.2025, 15:49

double deg = double.Parse(Console.ReadLine());
string time = Console.ReadLine().ToLower();

string outfit = string.Empty;
string shoes = string.Empty;

if (deg >= 10 && deg <= 18)
{
    if (time == "morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (time == "afternoon")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (time == "evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
else if (deg > 18 && deg <= 24)
{
    if (time == "morning")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (time == "afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (time == "evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
else if (deg > 24)
{
    if (time == "morning")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (time == "afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else if (time == "evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");