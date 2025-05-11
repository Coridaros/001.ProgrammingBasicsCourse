//Conditional statements advanced - lab, Task 007
//10.05.2025, 12:52

int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine().ToLower();

string result = string.Empty;

if(hour >= 10 && hour <= 18)
{
    if(day != "sunday")
    {
        result = "open";
    }
    else
    {
        result = "closed";
    }
}
else
{
    result = "closed";
}

Console.WriteLine(result);