//Conditional statements - exercise, Task 008
//10.05.2025, 01:07

string movieName = Console.ReadLine();
int movieTime = int.Parse(Console.ReadLine());
int breakTime = int.Parse(Console.ReadLine());

double lunchTime = breakTime / 8.0;
double restingTime = breakTime / 4.0;
double totalTime = breakTime - (lunchTime + restingTime);

if(totalTime >= movieTime)
{
    double leftTime = Math.Ceiling(totalTime - movieTime);
    Console.WriteLine($"You have enough time to watch {movieName} and left with {leftTime} minutes free time.");
}
else
{
    double nTime = Math.Ceiling(movieTime - totalTime);
    Console.WriteLine($"You don't have enough time to watch {movieName}, you need {nTime} more minutes.");
}