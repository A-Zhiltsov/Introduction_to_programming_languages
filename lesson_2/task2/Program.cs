// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
int b =  a%10;
int c = (a/10)%10;
Console.WriteLine(Math.Pow(c, b));