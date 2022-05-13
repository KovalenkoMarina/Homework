Console.WriteLine("Введите номер дня недели ");
int number_day = int.Parse(Console.ReadLine());
if (number_day == 6 || number_day == 7)
{
    Console.Write("Это выходной день");
}
else
{
    Console.WriteLine("Это рабочий день");
}

