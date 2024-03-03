// See https://aka.ms/new-console-template for more information
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("1");
    }
    else
    {
        Console.WriteLine("2");
    }
}
else
{
    if (y > 0)
    {
        Console.WriteLine("4");
    }
    else
    {
        Console.WriteLine("3");
    }
}