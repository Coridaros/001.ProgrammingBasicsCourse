//Conditional statements - exercise, Task 005
//09.05.2025, 23:58

double movieBudjet = double.Parse(Console.ReadLine());
int statistCnt = int.Parse(Console.ReadLine());
double statistEquipPrice = double.Parse(Console.ReadLine());

double discount = 0.0;
double decorPrice = movieBudjet * 0.10;
double equipPrice = statistCnt * statistEquipPrice;

if(statistCnt > 150)
{
    discount = equipPrice * 0.10;
    equipPrice -= discount;
}

double total = decorPrice + equipPrice;

if(total > movieBudjet)
{
    double nMoney = total - movieBudjet;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {nMoney:F2} leva more.");
}
else
{
    double lMoney = movieBudjet - total;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {lMoney:F2} leva left.");
}
