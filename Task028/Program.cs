// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(num);
Console.WriteLine($"Факториал числа {num} равна {factorial}");

int Factorial(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        checked
        {
            mult *= i;
        }
    }
    return mult;
}