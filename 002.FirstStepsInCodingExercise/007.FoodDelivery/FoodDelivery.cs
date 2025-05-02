//First steps in coding - exercise, Task 007
//03.05.2025, 00:21

int chikenCnt = int.Parse(Console.ReadLine());
int fishCnt = int.Parse(Console.ReadLine());
int vegetableCnt = int.Parse(Console.ReadLine());

double price = chikenCnt * 10.35 + fishCnt * 12.40 + vegetableCnt * 8.15;
double desertPrice = price * 0.20;
double finalPrice = price + desertPrice + 2.50;

Console.WriteLine(finalPrice);