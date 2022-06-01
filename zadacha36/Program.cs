//В прямоугольной матрице найти строку с наименьшей суммой элементов.
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

int min=100000000;
int a = -1;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    
    for (int j = 0; j < matrix.GetLength(1); j++)

    {
        sum = sum + matrix[i, j];

    }
    Console.WriteLine($"Сумма стрoки {i} равна {sum}");
    if (sum < min) 
    {
        min = sum;
        a = i;
        
    }
}
Console.WriteLine($"Минимальная сумма у стрoки {a} равна {min}");