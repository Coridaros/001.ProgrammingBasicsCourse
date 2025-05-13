//For loop - lab, Task 004
//11.05.2025, 22:24

int n = int.Parse(Console.ReadLine());

int number = 1;

for(int i = 0; i < n; i++)
{
    Console.WriteLine(number);

    number = number * 2 * 2;
}