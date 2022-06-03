// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент (первый).
Console.Write("Введите число строк ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число столбцов ");
int k = int.Parse(Console.ReadLine() ?? "");


void PrintArray(int[,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            Console.Write($"{matr[n, k]} ");
        }
        Console.WriteLine();
    }

}
void FillArray(int[,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            matr[n, k] = new Random().Next(1, 10);

        }

    }
}
int[,] matrix = new int[n, k];
Console.WriteLine("Исходный массив");
FillArray(matrix);
PrintArray(matrix);

int min = 10;
int a =0;
int b = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]<min) 
            {
                min = matrix[i,j];
                a = i;
                b = j;}


        } 

    }

Console.WriteLine($"Минимальный элемент {min} координаты первого такого элемента [{a}; {b}]");
void PrintArray1(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i!=a && j!=b) Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}
Console.WriteLine("Массив с удаленной строкой и столбцом ");
PrintArray1(matrix);