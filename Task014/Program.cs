// Задача 14.
// Напишите программу, которая
// 1. принимает на вход число 
// 2. проверяет кратно ли оно одновременно 7 и 23

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numA = number % 7;
// int numB = number % 23;

// if (numA == 0 && numB == 0)
//     Console.WriteLine($"число {number} кратно 7 и 23");
// else
//     Console.WriteLine($"число {number} не кратно 7 и 23");


// bool IncomingNum(int number, int numA, int numB)
// // если в методе сразу на проверяемые числа ввести переменные, то потом в строке 26 их можно менять на любые и проводить прверку с разными числами
// {
//     return number % numA == 0 && number % numB == 0;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool result = IncomingNum(num, 7, 23);
// if (result)
//   Console.Write("да");  
// else 
// Console.Write("нет");

// или

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Remains (int a, int b)
{
    return a%b == 0;
}
if (Remains(number,7) && Remains(number,23)) 
Console.Write("да");
else 
Console.Write("нет");