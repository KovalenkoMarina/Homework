﻿Console.WriteLine("Введите х1");
float x1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите у1 ");
float y1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите х2");
float x2 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите у2 ");
float y2 = float.Parse(Console.ReadLine());
double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
Console.WriteLine("Расстояние между точками " + result);

