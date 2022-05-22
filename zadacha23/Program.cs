//Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел
int[] array = new int[10];
int count1 = 0;
int count2 = 0;
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]}  ");
    if (array[i]%2==0)
    {
        count1++;
    }
    else
    {
        count2++;
    }
    
}
Console.WriteLine();
Console.WriteLine("количество четных чисел " + count1);
Console.WriteLine("количество нечетных чисел " + count2);
