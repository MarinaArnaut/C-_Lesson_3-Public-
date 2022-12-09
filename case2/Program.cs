// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
//  между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите x координату точки А: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите y координату точки А: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите z координату точки А: ");
int z = int.Parse(Console.ReadLine()!);
Console.Write("Введите x координату точки B: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y координату точки B: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите z координату точки B: ");
int z2 = int.Parse(Console.ReadLine()!);

double d = Math.Sqrt(((x2 - x) * (x2 - x)) + ((y2 - y) * (y2 - y)) + ((z2 - z) * (z2 - z)));

Console.Write($"Расстояние между точками A и B: " + Math.Round(d, 2));
