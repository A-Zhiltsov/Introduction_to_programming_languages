using System.Data;

Console.WriteLine("Введите число а");
string num1 = Console.ReadLine();
int a = int.Parse(num1);
Console.WriteLine("Введите число b");
string num2 = Console.ReadLine();
int b = int.Parse(num2);
if (a == b*b)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}