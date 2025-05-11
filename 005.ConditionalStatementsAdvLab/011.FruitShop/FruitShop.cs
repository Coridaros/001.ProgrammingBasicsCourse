//Conditional statements advanced - lab, Task 011
//10.05.2025, 13:39

string product = Console.ReadLine().ToLower();
string day = Console.ReadLine().ToLower();
double quantity = double.Parse(Console.ReadLine());

double result = 0.0;
bool valid = true;

switch(day)
{
    case "monday":
    case "tuesday":
    case "wednesday":
    case "thursday":
    case "friday":
        {
            if(product == "banana")
            {
                result = quantity * 2.50;
            }
            else if(product == "apple")
            {
                result = quantity * 1.20;
            }
            else if(product == "orange")
            {
                result = quantity * 0.85;
            }
            else if(product == "grapefruit")
            {
                result = quantity * 1.45;
            }
            else if(product == "kiwi")
            {
                result = quantity * 2.70;
            }
            else if(product == "pineapple")
            {
                result = quantity * 5.50;
            }
            else if(product == "grapes")
            {
                result = quantity * 3.85;
            }
            else
            {
                Console.WriteLine("error");
                valid = false;
            }
        }
        break;
    case "saturday":
    case "sunday":
        {
            if (product == "banana")
            {
                result = quantity * 2.70;
            }
            else if (product == "apple")
            {
                result = quantity * 1.25;
            }
            else if (product == "orange")
            {
                result = quantity * 0.90;
            }
            else if (product == "grapefruit")
            {
                result = quantity * 1.60;
            }
            else if (product == "kiwi")
            {
                result = quantity * 3.00;
            }
            else if (product == "pineapple")
            {
                result = quantity * 5.60;
            }
            else if (product == "grapes")
            {
                result = quantity * 4.20;
            }
            else
            {
                Console.WriteLine("error");
                valid = false;
            }
        }
        break;
    default:
        Console.WriteLine("error");
        valid = false;
        break;
}

if(valid)
{
    Console.WriteLine($"{result:F2}");
}