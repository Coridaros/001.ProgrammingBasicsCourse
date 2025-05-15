//For loop - exercise, Task 002
//12.05.2025, 22:46

int n = int.Parse(Console.ReadLine());

int sum = 0;
int max = int.MinValue;

for(int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    sum += number;

    if(number > max)
    {
        max = number;
    }
}

int sumWithoutMaxNumber = sum - max;

if(max == sumWithoutMaxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}
else
{
    int diff = Math.Abs(max - sumWithoutMaxNumber);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = " + diff);
}