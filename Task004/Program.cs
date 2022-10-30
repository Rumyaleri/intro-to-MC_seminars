// Задача 4: 
// Напишите программу, которая 
// принимает на вход три числа 
// и 
// выдаёт максимальное из этих чисел.

Console.Write("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("Максимальное число: ");
Console.Write(max);
