//Conditional statements advanced - lab, Task 004
//10.05.2025, 02.07

double age = double.Parse(Console.ReadLine());
string gender = Console.ReadLine().ToLower();

if(gender == "f")
{
    if(age < 16)
    {
        Console.WriteLine("Miss");
    }
    else
    {
        Console.WriteLine("Ms.");
    }
}
else if(gender == "m")
{
    if(age < 16)
    {
        Console.WriteLine("Master");
    }
    else
    {
        Console.WriteLine("Mr.");
    }
}