// Задача 20
// Напишите программу, которая 
// 1. на вход принимает координаты двух точек и 
// 2. находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

// Теорема Пифагора: Сумма квадратов катетов равна квадрату гипотенузы 

// double d = 5.09995123;
// double resD = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(resD);

// Math.Sqrt(56);
// Math.Pow(2, 10); 2 в степени 10

Console.WriteLine("введите координаты X точки 1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты Y точки 1 : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты X точки 2 : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты Y точки 2 : ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Round(Distanse(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Длина отрезка равна: {distanse}");

double Distanse(int x1, int y1, int x2, int y2)
{
        double dist = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        return dist;
    }