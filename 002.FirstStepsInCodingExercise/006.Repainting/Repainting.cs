//First steps in coding - exercise, Task 006
//02.05.2025, 20:56

int nNaylon = int.Parse(Console.ReadLine());
int nDye = int.Parse(Console.ReadLine());
int nRaz = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double naylonPrice = (nNaylon + 2) * 1.50;
double addDye = nDye * 0.10;
double dyePrice = (nDye + addDye) * 14.50;
double razPrice = nRaz * 5.00;
double expence = naylonPrice + dyePrice + razPrice + 0.40;
double workersPrice = (expence * 0.30) * hours;

Console.WriteLine(expence + workersPrice);

