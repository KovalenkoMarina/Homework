//Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int sum = 0;
int sum1 = 0;
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write($"{array[i]}  ");
    if (array[i]>0)
    {
        sum = sum + array[i];
    }
    if (array[i]<0)
    {
        sum1 = sum1 + array[i];
    }
    
}
Console.WriteLine();
Console.WriteLine("сумма положительных " + sum);
if (sum1 ==0) Console.WriteLine("отрицательных чисел в заданном диапазоне нет");
else Console.WriteLine("сумма отрицательных " + sum1);


