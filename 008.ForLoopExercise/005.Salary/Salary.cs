//For loop - exercise, Task 005
//12.05.2025, 23:12

int n = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string tabName = Console.ReadLine();

    if(tabName == "Facebook")
    {
        salary -= 150;
    }
    else if(tabName == "Instagram")
    {
        salary -= 100;
    }
    else if(tabName == "Reddit")
    {
        salary -= 50;
    }

    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}

if(salary > 0)
{
    Console.WriteLine(salary);
}