//Conditional statements - exercise, Task 004
//09.05.2025, 23:44

double vacantionPrice = double.Parse(Console.ReadLine());
int puzzleCnt = int.Parse(Console.ReadLine());
int muppetCnt = int.Parse(Console.ReadLine());
int teddybearCnt = int.Parse(Console.ReadLine());
int minionCnt = int.Parse(Console.ReadLine());
int truckCnt = int.Parse(Console.ReadLine());

double discount = 0.0;
double rent = 0.0;

int toyCnt = puzzleCnt + muppetCnt + teddybearCnt + minionCnt + truckCnt;

double earnedMoney = puzzleCnt * 2.60 + muppetCnt * 3 + teddybearCnt * 4.10 +
    minionCnt * 8.20 + truckCnt * 2;

if(toyCnt >= 50)
{
    discount = earnedMoney * 0.25;
    earnedMoney -= discount;
}

rent = earnedMoney * 0.10;
earnedMoney -= rent;

if(earnedMoney >= vacantionPrice)
{
    double leftMoney = earnedMoney - vacantionPrice;
    Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
}
else
{
    double nMoney = vacantionPrice - earnedMoney;
    Console.WriteLine($"Not enough money! {nMoney:F2} lv needed.");
}