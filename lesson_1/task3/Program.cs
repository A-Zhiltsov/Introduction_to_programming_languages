Console.WriteLine("Введите целое трехзначное число");
string numstr = Console.ReadLine();
int num = int.Parse(numstr);
Console.Write(num/100+num%10);