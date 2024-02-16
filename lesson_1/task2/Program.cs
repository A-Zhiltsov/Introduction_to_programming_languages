Console.WriteLine("введите число N");
string n_str = Console.ReadLine();
int n = int.Parse(n_str);
for (int i = -n; i <= n; i++)
{
    Console.Write(i+" ");
}