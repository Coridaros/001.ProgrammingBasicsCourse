//Conditional statements advanced - exercise, Task 004
//11.05.2025, 16:35

double budjet = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermanCnt = int.Parse(Console.ReadLine());

double discount = 0.0;
double extraDiscount = 0.0;
double price = 0.0;

if (season == "Spring")
{
    price = 3000;

    if (fishermanCnt <= 6)
    {
        discount = price * 0.10;
        price -= discount;
    }
    else if (fishermanCnt > 6 && fishermanCnt <= 11)
    {
        discount = price * 0.15;
        price -= discount;
    }
    else if (fishermanCnt > 11)
    {
        discount = price * 0.25;
        price -= discount;
    }

    if (fishermanCnt % 2 == 0)
    {
        extraDiscount = price * 0.05;
        price -= extraDiscount;
    }
}
else if (season == "Summer")
{
    price = 4200;

    if (fishermanCnt <= 6)
    {
        discount = price * 0.10;
        price -= discount;
    }
    else if (fishermanCnt > 6 && fishermanCnt <= 11)
    {
        discount = price * 0.15;
        price -= discount;
    }
    else if (fishermanCnt > 11)
    {
        discount = price * 0.25;
        price -= discount;
    }

    if (fishermanCnt % 2 == 0)
    {
        extraDiscount = price * 0.05;
        price -= extraDiscount;
    }
}
else if (season == "Autumn")
{
    price = 4200;

    if (fishermanCnt <= 6)
    {
        discount = price * 0.10;
        price -= discount;
    }
    else if (fishermanCnt > 6 && fishermanCnt <= 11)
    {
        discount = price * 0.15;
        price -= discount;
    }
    else if (fishermanCnt > 11)
    {
        discount = price * 0.25;
        price -= discount;
    }
}
else if (season == "Winter")
{
    price = 2600;

    if (fishermanCnt <= 6)
    {
        discount = price * 0.10;
        price -= discount;
    }
    else if (fishermanCnt > 6 && fishermanCnt <= 11)
    {
        discount = price * 0.15;
        price -= discount;
    }
    else if (fishermanCnt > 11)
    {
        discount = price * 0.25;
        price -= discount;
    }

    if (fishermanCnt % 2 == 0)
    {
        extraDiscount = price * 0.05;
        price -= extraDiscount;
    }
}

if (price <= budjet)
{
    double lMoney = budjet - price;
    Console.WriteLine($"Yes! You have {lMoney:F2} leva left.");
}
else
{
    double nMoney = price - budjet;
    Console.WriteLine($"Not enough money! You need {nMoney:F2} leva.");
}