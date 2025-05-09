//Conditional statements - lab, Task 007
//03.05.2025, 01:31

string figure = Console.ReadLine();

if(figure == "square")
{
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine($"{(a * a):F3}");
}
else if(figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());

    double area = a * b;

    Console.WriteLine($"{area:F3}");
}
else if(figure == "circle")
{
    double r = double.Parse(Console.ReadLine());

    double area = Math.PI * r * r;

    Console.WriteLine($"{area:F3}");
}
else if(figure == "triangle")
{
    double a = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());

    double area = a * h / 2;

    Console.WriteLine($"{area:F3}");
}