Console.WriteLine("Введите делимое ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите делитель ");
int b = int.Parse(Console.ReadLine());
int c = a%b;
if (c == 0)
{
    Console.WriteLine("Число кратно заданному");
}
else
{
    Console.WriteLine("Число некратно заданному, остаток = " +c);
}
