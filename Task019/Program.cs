// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212->нет
// 12821->да
// 23432->да


// просто программа

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 9999 && num < 100000)
// {
//     int digit5 = num % 10;
//     int digit4 = num / 10 % 10;
//     int digit2 = num / 1000 % 10;
//     int digit1 = num / 10000;
//     if (digit5 == digit1 && digit4 == digit2)
//     Console.WriteLine($"Число {num} является палиндромом");
//     else 
//     Console.WriteLine($"Число {num} не является палиндромом");
// }
// else
// Console.WriteLine("Некорректный ввод");


// с методом

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 9999 && num < 100000)
// {
//     if (MirrorCheck(num))
//     Console.WriteLine($"Число {num} является палиндромом");
//     else 
//     Console.WriteLine($"Число {num} не является палиндромом");
// }
//    else Console.WriteLine("Некорректный ввод");

// bool MirrorCheck(int number)
// {
//     int digit5 = number % 10;
//     int digit4 = number / 10 % 10;
//     int digit2 = number / 1000 % 10;
//     int digit1 = number / 10000;
//     return digit5 == digit1 && digit4 == digit2;
// }


// проверка палиндрома до 10 чисел

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == GetReverse(num))
    Console.WriteLine($"Число {num} является палиндромом");
else Console.WriteLine($"Число {num} не является палиндромом");

int GetReverse(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result * 10 + number % 10;
        number = number / 10;
    }
    return result;
}

