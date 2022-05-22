//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
 //второй и предпоследний и т.д.
int[] array = new int[10];
Console.WriteLine("Одномерный массив");
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write($"{array[i]}  ");
   
}
Console.WriteLine();
Console.WriteLine("Произведения пар чисел");
for (int j=0; j<array.Length/2; j++) 
{
    array[j] = array[j]*array[array.Length-j-1];
    Console.Write($"{array[j]}  ");
}

