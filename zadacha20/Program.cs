Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Кубы чисел от 1 до {n}, заканчивающиеся на четную цифру");
int a = 1;
while (a <= n)
{
    int b = a*a*a;
    if (b%2 == 0)
    {
        Console.WriteLine(b + " "); 
    }
        a++;
}
