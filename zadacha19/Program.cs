Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
int number = 0;
int sum = 0;
while (n > 0)
{
    number = n%10;
    sum = sum + number;
    n = n/10;
}
Console.WriteLine($"Сумма в числе {sum}");
