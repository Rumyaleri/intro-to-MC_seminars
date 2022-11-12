// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers(int num1)
{
    if (num1 == 0) return num1;
    return num1 % 10 + NaturalNumbers(num1 / 10);
}
int number = NaturalNumbers(num);
Console.WriteLine($"{number}");

