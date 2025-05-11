//Conditional statements advanced - lab, Task 010
//10.05.2025, 13:10

int number = int.Parse(Console.ReadLine());

bool isValid = (number >= 100 && number <= 200) || number == 0;

if(!isValid)
{
    Console.WriteLine("invalid");
}