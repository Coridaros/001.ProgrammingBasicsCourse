//Conditional statements advanced - lab, Task 006
//10.05.2025, 12:49

int number = int.Parse(Console.ReadLine());

bool inRange = (number >= -100 && number <= 100) && number != 0;

if(inRange)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}