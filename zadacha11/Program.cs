Console.WriteLine("Введите число 1 ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int b = int.Parse(Console.ReadLine());
if (a == b*b || b == a*a)
{
    Console.Write("YES");
}
else
{
    Console.WriteLine("No");
}

