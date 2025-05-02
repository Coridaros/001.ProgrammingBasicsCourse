//First steps in coding - exercise, Task 005
//02.05.2025, 20:49

int penCnt = int.Parse(Console.ReadLine());
int markeCnt = int.Parse(Console.ReadLine());
int cleanerLitters = int.Parse(Console.ReadLine());
int discountPercent = int.Parse(Console.ReadLine());

double nMoney = penCnt * 5.80 + markeCnt * 7.2 + cleanerLitters * 1.20;
double discount = nMoney * (discountPercent / 100.0);
nMoney -= discount;

Console.WriteLine(nMoney);