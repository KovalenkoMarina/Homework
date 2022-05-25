// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
int[] array = new int[8];
Console.WriteLine("Вершины фигуры");
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    
}
Console.Write($"({array[0]},{array[1]}) ({array[2]},{array[3]}) ({array[4]},{array[5]}) ({array[6]},{array[7]})");
Console.WriteLine();
Console.WriteLine("Введите коэффициент маштабирования k =  ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Координаты вершин новой фигуры ");
for (int i = 2; i<array.Length; i++)
{
    array[i] = array[i] * k;
    
}
Console.Write($"({array[0]},{array[1]}) ({array[2]},{array[3]}) ({array[4]},{array[5]}) ({array[6]},{array[7]})");