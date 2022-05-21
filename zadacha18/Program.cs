Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень ");
int b = int.Parse(Console.ReadLine());
int n = 1;
int result = 1;
while (n <= b)
{
    result = result*a;
    n++;
}
Console.Write(result);
