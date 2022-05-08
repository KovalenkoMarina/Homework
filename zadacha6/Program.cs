Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
int a = n/10;
int b = n%10;
Console.WriteLine("Наибольшая цифра ");
if (a>b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
