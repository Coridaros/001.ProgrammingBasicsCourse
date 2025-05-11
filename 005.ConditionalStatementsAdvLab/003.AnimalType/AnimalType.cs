//Conditional statements advanced - lab, Task 003
//10.05.2025, 02:02

string animal = Console.ReadLine();

switch(animal)
{
    case "dog":
        Console.WriteLine("mammal");
        break;
    case "crocodile":
    case "tortoise":
    case "snake":
        Console.WriteLine("reptile");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}