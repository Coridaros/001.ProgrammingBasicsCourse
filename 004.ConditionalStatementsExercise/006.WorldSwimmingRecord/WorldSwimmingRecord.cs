//Conditional statements - exercise, Task 006
//10.05.2025, 00:16

double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timePerMeter = double.Parse(Console.ReadLine());

double time = distance * timePerMeter;
double slow = Math.Floor(distance / 15) * 12.5;
double totalTime = time + slow;

if(totalTime >= record)
{
    double nSeconds = totalTime - record;
    Console.WriteLine($"No, he failed! He was {nSeconds:F2} seconds slower.");
}
else
{
    double lSeconds = record - totalTime;
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}