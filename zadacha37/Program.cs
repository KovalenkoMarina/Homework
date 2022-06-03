// Найти произведение двух матриц
Console.Write("Введите число строк первой марицы ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число столбцов первой матрицы и строк второй");
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
Console.WriteLine("Первая матрица");
FillArray(matrix);
PrintArray(matrix);

Console.Write("Введите число столбцов второй матрицы ");
int k1 = int.Parse(Console.ReadLine() ?? "");


void PrintArray1(int[,] matr1)
{
    for (int k = 0; k < matr1.GetLength(0); k++)
    {
        for (int k1 = 0; k1 < matr1.GetLength(1); k1++)
        {
            Console.Write($"{matr1[k, k1]} ");
        }
        Console.WriteLine();
    }

}
void FillArray1(int[,] matr1)
{
    for (int k = 0; k < matr1.GetLength(0); k++)
    {
        for (int k1 = 0; k1 < matr1.GetLength(1); k1++)
        {
            matr1[k, k1] = new Random().Next(1, 10);

        }

    }
}
int[,] matrix1 = new int[k, k1];
Console.WriteLine("Вторая матрица");
FillArray1(matrix1);
PrintArray1(matrix1);

int[,] m = new int[matrix.GetLength(0), matrix1.GetLength(1)];
void FillArray2(int[,] m)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix1.GetLength(0); ++j)
            for (int a = 0; a < matrix1.GetLength(1); ++a)
                    m[i, a] += matrix[i, j] * matrix1[j, a];
    
}
void PrintArray2(int[,] m)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int a = 0; a < matrix1.GetLength(1); ++a)
            Console.Write($"{m[i, a]} ");
        Console.WriteLine();
    }

}
FillArray2(m);
PrintArray2(m);
       