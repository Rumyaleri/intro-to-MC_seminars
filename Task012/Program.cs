// Задача 12.
// Напишите программу, которая 
// 1. на вход будет принимать 2 числа и
// 2. выводить, является ли первое число кратным второму
// 3. выводить остаток от деления, если 1 число не кратно 2.




Console.Write("введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int remains = numberA % numberB;

if (remains == 0)
Console.WriteLine($"число {numberA} кратно {numberB}");
else 
Console.WriteLine($"число {numberA} не кратно {numberB}, остаток {remains}");

