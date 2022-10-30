// // 1. Напишите программу, которая 
// // 1. на вход принимает два числа и 
// // 2. проверяет, является ли первое число квадратом второго.
// // a = 25, b = 5 -> да
// // a = 2, b = 10 -> нет
// // a = 9, b = -3 -> да
// // a = -3 b = 9 -> нет

Console.Write("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB == numberA * numberA)
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");
else
    Console.WriteLine($"Число {numberB} не является квадратом числа {numberA}");
