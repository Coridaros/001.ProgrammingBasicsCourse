//Conditional statements - exercise, Task 007
//10.05.2025, 00:51

double budjet = double.Parse(Console.ReadLine());
int videoCardCnt = int.Parse(Console.ReadLine());
int cpuCnt = int.Parse(Console.ReadLine());
int ramCnt = int.Parse(Console.ReadLine());

double videoCardPrice = videoCardCnt * 250;
double cpuPrice = cpuCnt * (videoCardPrice * 0.35);
double ramPrice = ramCnt * (videoCardPrice * 0.10);

double discount = 0.0;
double total = videoCardPrice + cpuPrice + ramPrice;

if(videoCardCnt > cpuCnt)
{
    discount = total * 0.15;
    total -= discount;
}

if(budjet >= total)
{
    double lMoney = budjet - total;
    Console.WriteLine($"You have {lMoney:F2} leva left!");
}
else
{
    double nMoney = total - budjet;
    Console.WriteLine($"Not enough money! You need {nMoney:F2} leva more!");
}