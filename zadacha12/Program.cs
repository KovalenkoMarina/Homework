Console.WriteLine("Введите номер четверти координатной плоскости ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
{
    Console.Write("x > 0, y > 0");
}
if (quarter == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
if (quarter == 3)
{
    Console.Write("x < 0, y < 0");
}
if (quarter == 4)
{
    Console.WriteLine("x > 0, y < 0");
}


