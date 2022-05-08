Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
if (n>99 && n<1000)
{
    Console.WriteLine("Вторая цифра ");
    Console.Write((n%100)/10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
