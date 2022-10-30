// Задача 43: 
// Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
    Console.Write("Заданные прямые не пересекаются");
    return;
} 

double[] arr = CrossPoint(b1, k1, b2, k2);
PrintArray(arr);

double[] CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2),2, MidpointRounding.AwayFromZero);
    double y = Math.Round((k1*x+b1), 2, MidpointRounding.AwayFromZero);
    double[] list = new double[2];
    list[0] = x;
    list[1] = y;
return list;
}
void PrintArray(double[] array)
{
    Console.Write("Координаты точки пересечения (");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(")");
}

