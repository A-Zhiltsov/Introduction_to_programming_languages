string a = Console.ReadLine();
int length = 1;
for (int j = 10; int.Parse(a)/j > 0; j=j*10)
{
    length++;
} 
for (int i = 0; i < length; i++)
{
    if (i == 0)
    {
        Console.Write(a[i]);
    }
    else
    {
    Console.Write(","+a[i]);
    }
}
