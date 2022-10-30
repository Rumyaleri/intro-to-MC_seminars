// Задача 40
// Напишите программу, которая
// 1.принимает на вход числа и 
// 2. проверяет, может ли существовать треугольник 
//    со сторонами такой длины.

Console.Write("Введите число 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int z = Convert.ToInt32(Console.ReadLine());

bool TriangleCheck (int num1, int num2, int num3)
{
   if(num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2)  return true;
   else return false;
}

bool result = TriangleCheck(x, y, z);
Console.Write(result);