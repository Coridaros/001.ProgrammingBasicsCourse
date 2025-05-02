//First steps in coding - lab, Task 009
//02.05.2025, 16:12

double area = double.Parse(Console.ReadLine());

double price = area * 7.61;
double discount = price * 0.18;
price -= discount;

Console.WriteLine($"The final price is: {price} lv.");
Console.WriteLine($"The discount is: {discount} lv.");