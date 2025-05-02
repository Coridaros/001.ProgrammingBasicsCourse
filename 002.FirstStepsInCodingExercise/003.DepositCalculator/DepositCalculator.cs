//First steps in coding - exercise, Task 003
//02.05.2025, 18:19

double deposit = double.Parse(Console.ReadLine());
int period = int.Parse(Console.ReadLine());
double vat = double.Parse(Console.ReadLine());

double addedVat = deposit * (vat / 100.0);
double monthVat = addedVat / 12;
double total = deposit + period * monthVat; ;

Console.WriteLine(total);