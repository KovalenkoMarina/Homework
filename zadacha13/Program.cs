Console.WriteLine("Введите х1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите у1 ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите х2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите у2 ");
int y2 = int.Parse(Console.ReadLine());
double result = Convert.ToInt32(Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1)));
Console.WriteLine("Расстояние между точками " + result);

