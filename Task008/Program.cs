// Задача 8: 
// Напишите программу, которая 
// на вход принимает число (N), 
// а 
// на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все четные числа в промежутке от 1 до {number} ");
int counter = 2;
// начало счетчика начинается от минимального значения 
while(counter <= number)
{
    Console.Write($"{counter} ");
    counter+=2;
}
