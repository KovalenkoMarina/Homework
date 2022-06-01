// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно
//  (в случае, если матрица не квадратная).

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
    if (n == k)
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] = matrix[j, i];
                

            }
        
        }
    }
}
void PrintnewArray(int[,] matrix1)
{
    if (n == k)
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
    else Console.WriteLine("Преобразование невозможно");
}
FillnewArray(matrix1);
PrintnewArray(matrix1);