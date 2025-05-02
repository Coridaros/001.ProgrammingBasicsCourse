//First steps in coding - exercise, Task 009
//03.05.2025, 00:43

int len = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double litters = (len * width * height) * 0.001;
double nLitters = litters * (1 - (percent / 100.0));

Console.WriteLine(nLitters);