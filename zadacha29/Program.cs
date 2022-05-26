//Написать программу копирования массива
int[] array1 = new int[10];
Console.WriteLine("Одномерный массив");
for (int i = 0; i<array1.Length; i++)
{
    array1[i] = new Random().Next(0,10);
    Console.Write($"{array1[i]}  ");
   
}
Console.WriteLine();
Console.WriteLine("Копия массива");
int[] array2 = new int[10];
for (int i = 0; i<array2.Length; i++)
{
    array2[i] = array1[i];
    Console.Write($"{array2[i]}  ");
   
}

