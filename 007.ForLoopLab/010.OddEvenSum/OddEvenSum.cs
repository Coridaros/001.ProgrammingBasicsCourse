//For loop - lab, Task 010
//11.05.2025, 22:53

int n = int.Parse(Console.ReadLine());

int evenSum = 0;
int oddSum = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        evenSum += number;
    }
    else
    {
        oddSum += number;
    }
}

if (evenSum == oddSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {evenSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
}