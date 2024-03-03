// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
int max = a%10;
if (a/10 > max)
{
    max = a/10;
}
Console.WriteLine(max);