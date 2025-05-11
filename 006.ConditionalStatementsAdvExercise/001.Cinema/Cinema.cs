//Conditional statements advanced - exercise, Task 001
//10.05.2025, 14:03

string type = Console.ReadLine().ToLower();
int r = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (type == "premiere")
{
    Console.WriteLine($"{(r * c * 12.0):F2} leva");
}
else if (type == "normal")
{
    Console.WriteLine($"{(r * c * 7.50):F2} leva");
}
else if (type == "discount")
{
    Console.WriteLine($"{(r * c * 5.0):F2} leva");
}