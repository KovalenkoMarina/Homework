// Написать программу, которая обменивает элементы первой строки и последней строки
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

Console.WriteLine();
Console.WriteLine("Преобразованный массив");
int[,] matrix1 = new int[n, k];
void FillnewArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            int a = matrix[matrix.GetLength(0) - 1, j];
            matrix1[matrix1.GetLength(0) - 1, j] = matrix[0, j];
            matrix1[0, j] = a;
            for (int s = 1; s < matrix1.GetLength(0) - 1; s++)
            {
                matrix1[s, j] = matrix[s, j];
            }
        }

    }
}
void PrintnewArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }

}
FillnewArray(matrix1);
PrintnewArray(matrix1);
