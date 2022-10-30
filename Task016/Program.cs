// Задача 16. 
// Напишите программу, которая 
// 1. принимает на вход два числа и
// 2. проверяет, является ли одно число квадратом другого


// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberA == numberB * numberB)
// Console.WriteLine($"число {numberA} является квадратом {numberB}");
// else if (numberB == numberA * numberA)
// Console.WriteLine($"число {numberB} является квадратом {numberA}");

// else 
// Console.WriteLine("нет");


// метод

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

bool CheckingNumber(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 ==num1;
 }
 if (CheckingNumber(numberA, numberB))
 Console.WriteLine("yes");
 else 
 Console.WriteLine("no");
