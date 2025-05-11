//Conditional statements advanced - exercise, Task 003
//11.05.2025, 16:16

string flowers = Console.ReadLine();
int flowersCnt = int.Parse(Console.ReadLine());
double budjet = double.Parse(Console.ReadLine());

double discount = 0.0;
double add = 0.0;
double price = 0.0;

if (flowers == "Roses")
{
    if (flowersCnt > 80)
    {
        price = flowersCnt * 5;
        discount = price * 0.10;
        price -= discount;
    }
    else
    {
        price = flowersCnt * 5;
    }
}
else if (flowers == "Dahlias")
{
    if (flowersCnt > 90)
    {
        price = flowersCnt * 3.80;
        discount = price * 0.15;
        price -= discount;
    }
    else
    {
        price = flowersCnt * 3.80;
    }
}
else if (flowers == "Tulips")
{
    if (flowersCnt > 80)
    {
        price = flowersCnt * 2.80;
        discount = price * 0.15;
        price -= discount;
    }
    else
    {
        price = flowersCnt * 2.80;
    }
}
else if (flowers == "Narcissus")
{
    if (flowersCnt < 120)
    {
        price = flowersCnt * 3;
        add = price * 0.15;
        price += add;
    }
    else
    {
        price = flowersCnt * 3;
    }
}
else if (flowers == "Gladiolus")
{
    if (flowersCnt < 80)
    {
        price = flowersCnt * 2.50;
        add = price * 0.20;
        price += add;
    }
    else
    {
        price = flowersCnt * 2.50;
    }
}

if (price <= budjet)
{
    double lMoney = budjet - price;
    Console.WriteLine($"Hey, you have a great garden with {flowersCnt} {flowers} and {lMoney:F2} leva left.");
}
else
{
    double nMoney = price - budjet;
    Console.WriteLine($"Not enough money, you need {nMoney:F2} leva more.");
}
