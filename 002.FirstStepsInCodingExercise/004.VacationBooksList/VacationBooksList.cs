//First steps in coding - exercise, Task 004
//02.05.2025, 20:38

int pagesCnt = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysCnt = int.Parse(Console.ReadLine());

int result = (pagesCnt / pagesPerHour) /  daysCnt;

Console.WriteLine(result);