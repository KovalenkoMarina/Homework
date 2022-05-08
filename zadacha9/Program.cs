Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

if (n>99)
{
    int x = n; 
    while (x >= 1000)
    {
        x = x / 10;
    }
    Console.WriteLine("Третья цифра ");
    Console.Write(x%10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
