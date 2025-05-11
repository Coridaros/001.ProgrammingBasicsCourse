//Conditional statements advanced - exercise, Task 006
//11.05.2025, 17:39

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
string symbol = Console.ReadLine();

double result = 0.0;
string oddEven = string.Empty;

if (symbol == "+")
{
    result = firstNumber + secondNumber;

    if (result % 2 == 0)
    {
        oddEven = "even";
    }
    else
    {
        oddEven = "odd";
    }

    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - {oddEven}");
}
else if (symbol == "-")
{
    result = firstNumber - secondNumber;

    if (result % 2 == 0)
    {
        oddEven = "even";
    }
    else
    {
        oddEven = "odd";
    }

    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - {oddEven}");
}
else if (symbol == "*")
{
    result = firstNumber * secondNumber;

    if (result % 2 == 0)
    {
        oddEven = "even";
    }
    else
    {
        oddEven = "odd";
    }

    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - {oddEven}");
}
else if (symbol == "/")
{
    if (secondNumber == 0)
    {
        Console.WriteLine($"Cannot divide {firstNumber} by zero");
    }
    else
    {
        result = firstNumber / (secondNumber * 1.0);

        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
    }
}
else if (symbol == "%")
{
    if (secondNumber == 0)
    {
        Console.WriteLine($"Cannot divide {firstNumber} by zero");
    }
    else
    {
        result = firstNumber % secondNumber;

        Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
    }
}
