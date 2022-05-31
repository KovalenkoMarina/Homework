//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
void FillnewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int b;
            for (int k = j+1; k < matrix.GetLength(1); k++)
            if (matrix[i,j]<matrix[i, k])
            {
                b = matrix[i,j];
                matrix[i,j]= matrix[i, k];
                matrix[i,k]= b;
            }
            
            // int max = 0;
            
                // Array.Sort(matrix);
            // matrix[matrix.GetLength(0)-1, j];
            // matrix[matrix.GetLength(0)-1, j] = matrix[0, j];
            // matrix[0, j] = a;
        }

    }
}
void PrintnewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}
FillnewArray(matrix);
PrintnewArray(matrix);
