﻿//For loop - lab, Task 007
//11.05.2025, 22:41

int n = int.Parse(Console.ReadLine());

int sum = 0;

for(int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    sum += number;
}

Console.WriteLine(sum);