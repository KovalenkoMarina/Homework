//Показать двумерный массив размером m×n заполненный вещественными числами
Console.Write("Введите число m ");
int m = int.Parse(Console.ReadLine()?? "");

Console.Write("Введите число n ");
int n = int.Parse(Console.ReadLine()?? "");

void PrintArray(double [,] matr)
{
    for (int m = 0; m <matr.GetLength(0); m++)
    {
        for(int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
    Console.WriteLine();
    }
}
void FillArray (double [,] matr)
{
    for (int m = 0; m <matr.GetLength(0); m++)
    {
        for(int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().NextDouble();
        }
    
    }
}
double[,] matrix = new double[m, n];


FillArray(matrix);
PrintArray(matrix);