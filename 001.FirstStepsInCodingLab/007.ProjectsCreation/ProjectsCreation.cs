//First steps in coding - lab, Task 007
//02.05.2025, 16:05

string architectName = Console.ReadLine();
int projectCnt = int.Parse(Console.ReadLine());

int neededTime = projectCnt * 3;

Console.WriteLine($"The architect {architectName} will need {neededTime} hours to complete {projectCnt} project/s.");