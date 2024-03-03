// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a%b == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет, "+(a%b));
}