// задача 11.
// Напишите программу, которая
// 1. выводит случайное трехзначное число и 
// 2. удаляет вторую цифру этого числа



// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int firstThirdDigit = firstDigit * 10 + thirdDigit;

// Console.WriteLine($"первая и последняя цифры числа {firstThirdDigit}");

//через метод

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {number}");

int NumberPrint(int num)
{
   int firstDigit = number / 100;
int thirdDigit = number % 10;

return firstDigit * 10 + thirdDigit;
}
int result = NumberPrint(number);
Console.WriteLine($"{number} => {result}");