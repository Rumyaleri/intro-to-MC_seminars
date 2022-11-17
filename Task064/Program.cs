// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

void NaturalNumbers(int num, int num2)
{
    if (num2 > num) return;
    NaturalNumbers(num, num2 + 1);
    Console.Write($"{num2} ");
}

NaturalNumbers(number, count);