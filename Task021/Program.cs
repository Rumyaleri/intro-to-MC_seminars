// Задача 21
// Напишите программу, которая
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("введите координаты X точки 1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты Y точки 1 : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты Z точки 1 : ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты X точки 2 : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты Y точки 2 : ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты Z точки 2 : ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Round(Distanse(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Длина отрезка равна: {distanse}");

double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
        double dist = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
        return dist;
    }

