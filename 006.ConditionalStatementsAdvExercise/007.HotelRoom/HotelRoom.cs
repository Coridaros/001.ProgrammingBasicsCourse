//Conditional statements advanced - exercise, Task 007
//11.05.2025, 17:53

string month = Console.ReadLine();
int nightCnt = int.Parse(Console.ReadLine());

double studioPrice = 0.0;
double apartamentPrice = 0.0;
double sDiscount = 0.0;
double aDiscount = 0.0;

if (month == "May" || month == "October")
{
    studioPrice = nightCnt * 50;
    apartamentPrice = nightCnt * 65;

    if (nightCnt > 7 && nightCnt <= 14)
    {
        sDiscount = studioPrice * 0.05;
        studioPrice -= sDiscount;
    }

    if (nightCnt > 14)
    {
        sDiscount = studioPrice * 0.30;
        aDiscount = apartamentPrice * 0.10;
        studioPrice -= sDiscount;
        apartamentPrice -= aDiscount;
    }
}
else if (month == "June" || month == "September")
{
    studioPrice = nightCnt * 75.20;
    apartamentPrice = nightCnt * 68.70;

    if (nightCnt > 14)
    {
        sDiscount = studioPrice * 0.20;
        aDiscount = apartamentPrice * 0.10;
        studioPrice -= sDiscount;
        apartamentPrice -= aDiscount;
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = nightCnt * 76.00;
    apartamentPrice = nightCnt * 77.00;

    if (nightCnt > 14)
    {
        aDiscount = apartamentPrice * 0.10;
        apartamentPrice -= aDiscount;
    }
}

Console.WriteLine($"Apartment: {apartamentPrice:F2} lv.");
Console.WriteLine($"Studio: {studioPrice:F2} lv.");