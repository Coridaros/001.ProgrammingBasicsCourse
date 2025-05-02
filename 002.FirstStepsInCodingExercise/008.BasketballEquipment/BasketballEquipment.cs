//First steps in coding - exercise, Task 008
//03.05.2025, 00:34

int tax = int.Parse(Console.ReadLine());

double shoesPrice = tax - (tax * 0.40);
double equipPrice = shoesPrice - (shoesPrice * 0.20);
double ballPrice = equipPrice / 4;
double accPrice = ballPrice / 5;

double finalPrice = shoesPrice + equipPrice + ballPrice + accPrice + tax;

Console.WriteLine(finalPrice);