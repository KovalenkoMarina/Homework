// Сформировать трехмерный массив не повторяющимися двузначными числами показать его
//  построчно на экран выводя индексы соответствующего элемента
Console.Write("Введите число строк ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число столбцов ");
int k = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите глубину массива ");
int m = int.Parse(Console.ReadLine() ?? "");
if (n*k*m >= 91) Console.WriteLine("Количество элементов превышает лимит");
else 
{
void PrintArray(int[,,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int m = 0; m < matr.GetLength(2); m++)
            {
                Console.Write($"{matr[n, k, m]} ");
            }
            Console.WriteLine();
        }
    }
}
void FillArray(int[,,] matr)
{
    int count = 10;
    for (int n = 0; n < matr.GetLength(0); n++)
        for (int k = 0; k < matr.GetLength(1); k++)
            for (int m = 0; m < matr.GetLength(2); m++)
            {
                matr[n, k, m] = count;
                count++;
                
            }
}
int[,,] matrix = new int[n, k, m];
FillArray(matrix);
PrintArray(matrix);}

