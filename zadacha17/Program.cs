Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {a} равна ");
int n = 1;
int sum = 0;
while (n <= a)
{
    sum= sum + n;    
    n++;
}
Console.Write(sum);