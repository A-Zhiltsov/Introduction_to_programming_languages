// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
if (a/100 > 0)
{
    Console.WriteLine(a/100%10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}